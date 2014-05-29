using KrasnoSeloShop.Models;
using KrasnoSeloShop.Repositories;
using KrasnoSeloShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KrasnoSeloShop.ControllerHelpers
{
    public static class SortProducts
    {
        public static IEnumerable<SwimSuitModel> SortSwimSuits(IRepository<Swimsuit> swimSuitRepository, string criteria)
        {
            IEnumerable<SwimSuitModel> swimSuits;
            if (criteria == "price")
            {
                swimSuits = swimSuitRepository.GetAll().OrderByDescending(o => o.Price).Select(item => new SwimSuitModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
                return swimSuits;
            }
            else if (criteria == "color")
            {
                var groupOfLists = swimSuitRepository.GetAll().GroupBy(color => color.Color);
                swimSuits = groupOfLists.SelectMany(o => o).Select(item => new SwimSuitModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            }
            else
            {
                swimSuits = swimSuitRepository.GetAll().OrderByDescending(o => o.Size).Select(item => new SwimSuitModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            }
            return swimSuits;
        }
        public static IEnumerable<JeansModel> Sorteans(IRepository<Jeans> jeansRepository, string criteria)
        {
            IEnumerable<JeansModel> jeans;
            if (criteria == "price")
            {
                jeans = jeansRepository.GetAll().OrderByDescending(o => o.Price).Select(item => new JeansModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            }
            else
            {
                jeans = jeansRepository.GetAll().OrderBy(o => o.Size).Select(item => new JeansModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            }
            return jeans;
        }
        public static IEnumerable<TShirtModel> SortTshirts(IRepository<TShirt> tshirtRepository, string criteria)
        {
            IEnumerable<TShirtModel> tshearts;
            if(criteria == "price")
            {
                tshearts = tshirtRepository.GetAll().OrderByDescending(o => o.Price).Select(item => new TShirtModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            }
            else
            {
                tshearts = tshirtRepository.GetAll().OrderByDescending(o => o.Size).Select(item => new TShirtModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            }
            return tshearts;
        }
    }
}