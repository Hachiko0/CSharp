namespace KrasnoSeloShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    public class Jeans : ICloth
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
