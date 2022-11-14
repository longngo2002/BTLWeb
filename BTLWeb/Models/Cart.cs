using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLWeb.Models
{
    public class Cart
    {
        public List<product> list { get; set; }
        public int total { get; set; }
    }
}