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
    public class InvoiceController:Controller
    {
        InvoiceRepository repository = new InvoiceRepository();
        // GET: Supplier
        public ActionResult Index()
        {
            var model = new InvoiceViewModel();
            model.Invoicelist = repository.GetInvoiceList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(Invoices invoice)
        {
            repository.AddInvoice(invoice);

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {

            return View();
        }
    }
}