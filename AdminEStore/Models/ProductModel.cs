using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace AdminEStore.Models
{
    public class ProductModel
    {

        public ProductModel ()
        {
            //ListProdCat = new List<ListProdCat>();
        }


        [Required]
        public int Product_ID { get; set; }
        
        [Required(ErrorMessage = "Please enter the product name")]
        public string Product_Name { get; set; }

        [Required (ErrorMessage ="Please enter the product price")]
        public int Product_Price { get; set; }
        
        [Required(ErrorMessage = "Please enter the product category")] 
        public string Product_Category { get; set; }

        public string Product_CatName { get; set; }

        //public ListProdCat ProductCategoryLookup { get; private set; }
        //public List<ListProdCat> ListProdCat { get;  set; }

    }
}