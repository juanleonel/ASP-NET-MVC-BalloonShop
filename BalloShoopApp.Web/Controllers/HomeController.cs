using BalloShoopApp.Domain.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BalloShoopApp.Web.Controllers
{
    public class HomeController : Controller
    {

        private CategoryDA _categoryDA;
        private CategoryDA CategoryDA
        {
            get { return _categoryDA ?? (_categoryDA = new CategoryDA()); }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            var data = CategoryDA.GetCategories().ToList();

            foreach (var item in data)
            {
                Console.WriteLine(item.Description);
            }
             
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult basic()
        {
            var category = new Models.Category();
            category.ID = 1;
            category.Name = "Toys";
            category.Description = "Description";

            return View(category);
        }
    }
}