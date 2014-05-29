using KrasnoSeloShop.Models;
using KrasnoSeloShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KrasnoSeloShop.Proxies
{
    public class JeansProxy
    {
        public IEnumerable<JeansModel> jeans { get; set; }
        public string Content { get; set; }
    }
}