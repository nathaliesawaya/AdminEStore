using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminEStore.Models
{
    public class ListProdCat
    {
        public ListProdCat()
        {
            CategoryLookup = new List<String>();
            CategoryLookup.Add("Food");
            CategoryLookup.Add("Electronics");
            CategoryLookup.Add("Games");
        }

        public List<String> CategoryLookup { get; set; }



    }
}