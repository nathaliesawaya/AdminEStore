using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminEStore.Models
{
    public class UserModel
    {


        public UserModel()
        {



        }
        [JsonProperty("id")]
        public int User_ID { get; set; }
        
        [JsonProperty("email")]
        public string User_Email { get; set; }
       
        [JsonProperty("first_name")] 
        public string User_FirstName { get; set; }
        
        [JsonProperty("last_name")]
        public string User_LastName { get; set; }

        [JsonProperty("avatar")]
        public string User_Avatar { get; set; }

}
}