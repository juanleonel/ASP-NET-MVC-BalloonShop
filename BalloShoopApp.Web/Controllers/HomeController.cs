using BalloShoopApp.Domain.DataAccess;
using BalloShoopApp.Web.Models;
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

        private DepartmentDA _departmentDA;
        private DepartmentDA DepartmentDA
        {
            get { return _departmentDA ?? (_departmentDA = new DepartmentDA()); }
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
            var category = new Models.Category
            {
                ID = 1,
                Name = "Toys",
                Description = "Description"
            };

            return View(category);
        }

        public ActionResult GetDepartments() 
        {
            List<vmDepartment> departments = new List<vmDepartment>();

            var result = DepartmentDA.GetDepartments().Select(x => new vmDepartment()
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                CreatedAt = x.CreatedAt,
                CreatedUser = x.CreatedUser,
                UpdatedAt = x.UpdatedAt,
                UpdatedUser = x.UpdatedUser
            }).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}