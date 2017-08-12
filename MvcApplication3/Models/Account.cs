using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Account
    {
        public String UserName {get;set;}
	    public int Id {get;set;}
        public String Name { get; set; }
        public int Age{ get; set; }
        public String Address{ get; set; }
        public String Password{ get; set; }
    }
}