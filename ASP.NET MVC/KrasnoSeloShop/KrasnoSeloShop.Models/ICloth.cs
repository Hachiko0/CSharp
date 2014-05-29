using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrasnoSeloShop.Models
{
    public interface ICloth
    {
        int ID { get; set; }
        string Name { get; set; }
        string URL { get; set; }
        decimal Price { get; set; }
        string Color { get; set; }
        int Size { get; set; }
        bool IsAvailable { get; set; }
    }
}
