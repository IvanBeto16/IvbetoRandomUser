using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class Usuario
    {
        public string gender { get; set; }
        public string email { get; set; }
        public Name name { get; set; }
        public Location location { get; set; }
        public Picture picture { get; set; }

    }
}