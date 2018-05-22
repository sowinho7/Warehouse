using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models;
using Warehouse.Repositories;
using Warehouse.ViewModel;
using ZXing;

namespace Warehouse.Controllers
{
    public class ProductController:Controller
    {
        ProductRepository repository = new ProductRepository();
        // GET: Supplier
        public ActionResult Index()
        {
            var model = new ProductViewModel();
            model.Productlist = repository.GetProductList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            repository.AddProduct(product);

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {

            return View();
        }
        [HttpGet]
        public ActionResult GetBarcode(string ean)
        {
            ean = "5900334000477";
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.EAN_13;

            var bitmap = writer.Write(ean);
            var bitmapBytes = BitmapToBytes(bitmap);
            return File(bitmapBytes, "image/jpeg");
        }

        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}