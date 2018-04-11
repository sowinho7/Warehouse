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
    public class SupplierController : Controller
    {
        SupplierRepository repository = new SupplierRepository();
        // GET: Supplier
        public ActionResult Index()
        {
            var model = new SupplierViewModel();
            model.Supplierslist = repository.GetSuppliersList();
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(Suppliers supplier)
        {
            repository.AddSupplier(supplier);

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {

            return View();
        }
    }
}