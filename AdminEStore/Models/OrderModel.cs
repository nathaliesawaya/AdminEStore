using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminEStore.Models
{
    public class OrderModel
    {
        public OrderModel()
        {
            ListOrderedProducts = new List<OrderedProducts>();

        }

        //public int Order_Id { get; set; }
        //public int Product_ID { get; set; }
        //public int Product_Price { get; set; }
        //public int Product_Quantity { get; set; }
        public List<OrderedProducts> ListOrderedProducts { get; set; }
    }
}