using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AdminEStore.Models
{
    public class RootObjectUsers
    {

        public RootObjectUsers()
        {
           Users = new List<UserModel>();
        }

        public List<UserModel> Users { get; set; }
    }

}   