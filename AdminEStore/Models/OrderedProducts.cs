using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminEStore.Models
{
    public class OrderedProducts
    {

        public int Order_Id { get; set; }
        public ProductModel Ordproduct { get; set; }
        public int Product_Quantity { get; set; }

    }

   
}