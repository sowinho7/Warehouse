using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models;
using Warehouse.Repositories;
using Warehouse.ViewModel;

namespace Warehouse.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository repository = new CategoryRepository();
        // GET: Supplier
        public ActionResult Index()
        {
            var model = new CategoryViewModel();
            model.Categorylist = repository.GetCategoryList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            repository.AddCategory(category);

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {

            return View();
        }
    }
}
