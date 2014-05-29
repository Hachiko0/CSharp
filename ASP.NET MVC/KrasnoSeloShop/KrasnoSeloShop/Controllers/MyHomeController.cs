using KrasnoSeloShop.Models;
using KrasnoSeloShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KrasnoSeloShop.Data;
using KrasnoSeloShop.ViewModels;

namespace KrasnoSeloShop.Controllers
{
    public class MyHomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult About()
        {
            return this.View();
        }
        public ActionResult Contacts()
        {
            return this.View();
        }
    }
}