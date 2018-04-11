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
    public class BrandController:Controller
    {
        BrandRepository repository = new BrandRepository();
        // GET: Supplier
        public ActionResult Index()
        {
            var model = new BrandViewModel();
            model.Brandlist = repository.GetBrandList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(Brand brand)
        {
            repository.AddBrand(brand);

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {

            return View();
        }
    }
}