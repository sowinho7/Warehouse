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
    public class CustomerController:Controller
    {
        CustomerRepository repository = new CustomerRepository();
        // GET: Supplier
        public ActionResult Index()
        {
            var model = new CustomerViewModel();
            model.Customerslist = repository.GetCustomersList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(Customers customer)
        {
            repository.AddCustomer(customer);

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {

            return View();
        }
    }
}