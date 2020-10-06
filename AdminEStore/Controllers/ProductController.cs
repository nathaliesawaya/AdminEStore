using AdminEStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;


using System.Text;

namespace AdminEStore.Controllers
{
    public class ProductController : Controller
    {
        

        [Route("Product/AddProduct/")]
        [HttpGet]
        public ActionResult AddProduct()
        {
          
            return View();
        }
 

        [Route("Product/AddProduct/")]
        [HttpPost]
        public JsonResult AddProduct(FormCollection collection)
        {
            ProductModel pmodel = new ProductModel();

            pmodel.Product_ID = 1;
            pmodel.Product_Name = collection["Product_Name"];
            pmodel.Product_Price = Convert.ToInt16(collection["Product_Price"]); 
            pmodel.Product_Category = collection["Product_Cat"];

            //Response.Write(collection.Count);

            string path = Server.MapPath("~/Myfiles/JSONFile.txt");

            if (System.IO.File.Exists(path))
            {
                // Create a file to write to.
                string jsonStr = JsonConvert.SerializeObject(pmodel);
                System.IO.File.AppendAllText(path, "\n" + jsonStr);
              
            }

            return Json(pmodel, JsonRequestBehavior.AllowGet);
        }

        [Route("Product/GetProductCat/")]
        [HttpGet]
        public JsonResult GetProductCat()
        {
            List<ProductCat> ProductCat = new List<Models.ProductCat>()
            {
                new Models.ProductCat(){CatId=1,CatName="Food"},
                new Models.ProductCat(){CatId=2,CatName="Electronics"},
                new Models.ProductCat(){CatId=3,CatName="Games"},
          
            };
      
            return Json(ProductCat, JsonRequestBehavior.AllowGet);
        }

    }

}