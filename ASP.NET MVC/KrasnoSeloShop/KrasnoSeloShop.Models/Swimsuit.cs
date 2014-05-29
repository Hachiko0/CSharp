using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrasnoSeloShop.Models
{
    public class Swimsuit : ICloth
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public bool IsAvailable { get; set; }
    }
}
