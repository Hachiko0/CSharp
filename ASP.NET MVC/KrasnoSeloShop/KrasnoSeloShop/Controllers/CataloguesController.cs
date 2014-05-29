namespace KrasnoSeloShop.Controllers
{
    using KrasnoSeloShop.Data;
    using KrasnoSeloShop.Models;
    using KrasnoSeloShop.Repositories;
    using KrasnoSeloShop.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using KrasnoSeloShop.ControllerHelpers;
    public class CataloguesController : Controller
    {
        //I should use UnitOfWorkPattern, because there are too many repositories
        private IRepository<Jeans> jeansRepository;
        private IRepository<Swimsuit> swimSuitRepository;
        private IRepository<TShirt> tshirtRepository;
        public CataloguesController()
        {
            this.jeansRepository = new DbGenericRepository<Jeans>(new KrasnoSeloShopContext());
            this.swimSuitRepository = new DbGenericRepository<Swimsuit>(new KrasnoSeloShopContext());
            this.tshirtRepository = new DbGenericRepository<TShirt>(new KrasnoSeloShopContext());

        }
        //public CataloguesController(IRepository<Jeans> iRepository)
        //{
        //    this.jeansRepository = iRepository;
        //}
        [ActionName("Seasons")]
        public ActionResult ChooseSeason()
        {
            return this.View();
        }
        public ActionResult Summer()
        {
            return this.View();
        }
        public ActionResult Autumn()
        {
            return this.View();
        }
        [ActionName("InProgress")]
        public ActionResult CatalogueInDevelopmentProgess()
        {
            return this.View();
        }
        [ActionName("Jeans")]
        public ActionResult GetJeans(string criteria)
        {
            this.ViewBag.Action = "GetJeansFullContent";
            this.ViewBag.selectListItems = GenerateDropDownList(new Tuple<string, string>("Цена", "price"), new Tuple<string, string>("Размер", "size"));
            if (Request.IsAjaxRequest())
            {
                var sorted = SortProducts.Sorteans(this.jeansRepository, criteria);
                return this.PartialView("Partial",sorted);
            }
            var jeans = this.jeansRepository.GetAll().Select(item => new JeansModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            return this.View(jeans);
        }
        [ActionName("Swimsuits")]
        public ActionResult GetSwimSuits(string criteria)
        {
            this.ViewBag.Action = "GetSwimSuitsFullContent";
            this.ViewBag.selectListItems =  GenerateDropDownList(new Tuple<string, string>("Цена", "price"), new Tuple<string, string>("Размер", "size"),new Tuple<string, string>("Цвят", "color"));
            if(Request.IsAjaxRequest())
            {
                var sorted = SortProducts.SortSwimSuits(this.swimSuitRepository, criteria);
                return this.PartialView("Partial", sorted);
            }
            var swimSuits = this.swimSuitRepository.GetAll().Select(item => new SwimSuitModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            return this.View(swimSuits);
        }
        [ActionName("Tshirts")]
        public ActionResult GetTShirts(string criteria)
        {
            this.ViewBag.Action = "GetTshirtsFullContent";
            this.ViewBag.selectListItems = GenerateDropDownList(new Tuple<string, string>("Цена", "price"), new Tuple<string, string>("Размер", "size"), new Tuple<string, string>("Цвят", "color"));
            if(Request.IsAjaxRequest())
            {
                var sorted = SortProducts.SortTshirts(this.tshirtRepository, criteria);
                return this.PartialView("Partial", sorted);
            }
            var tShirts = this.tshirtRepository.GetAll().Select(item => new TShirtModel { ID = item.ID, Price = item.Price, URL = item.URL }).ToList();
            return this.View(tShirts);
        }
        public ActionResult GetTshirtsFullContent(int id)
        {
            if (this.Request.IsAjaxRequest())
            {
                var item = this.tshirtRepository.Get(id);
                return this.PartialView("GetClothFullContent", item);
            }
            throw new Exception();
        }
        public ActionResult GetJeansFullContent(int id)
        {
            if (this.Request.IsAjaxRequest())
            {
                var item = this.jeansRepository.Get(id);
                item.IsAvailable = true;
                return this.PartialView("GetClothFullContent", item);
            }
            throw new Exception();
        }
        public ActionResult GetSwimSuitsFullContent(int id)
        {
            if(this.Request.IsAjaxRequest())
            {
                var item = this.swimSuitRepository.Get(id);
                item.IsAvailable = true;
                return this.PartialView("GetClothFullContent", item);
            }
            throw new Exception();
        }
        private IEnumerable<SelectListItem> GenerateDropDownList(params Tuple<string, string>[] pairs)
        {
            var list = new List<SelectListItem>(pairs.Count());
            foreach (var item in pairs)
            {
                list.Add(new SelectListItem { Text = item.Item1, Value = item.Item2 });
            }
            return list;
        }
    }
}