using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KrasnoSeloShop.ViewModels
{
    public interface IClothModel
    {
        int ID { get; set; }
        decimal Price { get; set; }
        string URL { get; set; }
    }
}