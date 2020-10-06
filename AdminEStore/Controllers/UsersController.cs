using AdminEStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdminEStore.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            List<UserModel> UserInfo = new List<UserModel>();

            string Baseurl = "https://reqres.in/";

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

 
                var responseTask = client.GetAsync("api/users");
                responseTask.Wait();
                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    var UserResponse = result.Content.ReadAsStringAsync().Result;
                                     
                    var json = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(UserResponse);
                    json.Property("page").Remove();
                    json.Property("per_page").Remove();
                    json.Property("total").Remove();
                    json.Property("total_pages").Remove();
                    json.Property("ad").Remove();

                    var strjson = json.ToString(Formatting.None);
                    strjson = strjson.Remove(strjson.Length - 1, 1);
                    strjson = strjson.Replace("{\"data\":", "");

                    //Deserializing the response recieved from web api and storing into the Users list  

                    UserInfo = JsonConvert.DeserializeObject<List<UserModel>>(strjson);

                }
                else //web api sent error response 
                {
                    //log response status here..
               
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(UserInfo);
        }
       
    }
 }