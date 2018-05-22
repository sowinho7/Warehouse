using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
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
        public ActionResult GetInvoice(int Id)
        {
           
            var model = repository.GetInvoice(Id);
            return View(model);
        }
        [HttpGet]
        public ActionResult AddInvoice()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddInvoice(Invoices invoice)
        {
            repository.AddInvoice(invoice);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteInvoice()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DeleteInvoice(int id)
        {
            repository.DeleteInvoice(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditInvoice()
        {
            var model = new InvoiceViewModel();
            model.Invoicelist = repository.GetInvoiceList();
            return View();
        }
        [HttpPost]
        public ActionResult EditInvoice(Invoices Invoice, int id)
        {
            repository.EditInvoice(Invoice,id);
            return RedirectToAction("Index");
        }

        public void GenerateInvoicePDF(int Id)
        {
            //Dummy data for Invoice (Bill).
            string CustomerName = "Kowalski Jan";
            string companyName = "Monaco Auto-Parts";
            int CustomerID = 1243;
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] {
      new DataColumn("Item Id", typeof(string)),
      new DataColumn("Item Name", typeof(string)),
      new DataColumn("Price", typeof(int)),
      new DataColumn("Quantity",  typeof(int)),
      new DataColumn("Total",  typeof(int))});
            dt.Rows.Add(5001, "Wires", 150, 15, 7500);
            dt.Rows.Add(5005, "Cables", 500, 3, 1500);
            dt.Rows.Add(5003, "Pins", 20, 30, 6000);
            dt.Rows.Add(5002, "Lan Wires", 50, 24, 1200);

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    StringBuilder sb = new StringBuilder();

                    //Generate Invoice (Bill) Header.
                    sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
                    sb.Append("<tr><td align='center' style='background-color: Blue;color:#ffffff' colspan = '2'><b>CUSTOMER ORDER SHEET</b></td></tr>");
                    sb.Append("<tr><td colspan = '2'></td></tr>");

                    sb.Append("<tr><td><b>Customer Name: </b>");
                    sb.Append(CustomerName);
                    sb.Append("</td><td align = 'right'><b>Date: </b>");
                    sb.Append(DateTime.Now);
                    sb.Append(" </td></tr>");
                    sb.Append("<tr><td colspan = '2'>");
                    sb.Append("</td></tr>");
                    sb.Append("<br />");

                    sb.Append("<tr><td><b>Order No: </b>");
                    sb.Append(CustomerID);
                    sb.Append("</td><td align = 'right'>");
                    sb.Append(" </td></tr>");
                    sb.Append("<tr><td colspan = '2'><b>Company Name: </b>");
                    sb.Append(companyName);
                    sb.Append("</td></tr>");
                    sb.Append("</table>");
                    sb.Append("<br />");

                    //Generate Invoice (Bill) Items Grid.
                    sb.Append("<table border = '1'>");
                    sb.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        sb.Append("<th style = 'background-color: Blue;color:#ffffff'>");
                        sb.Append(column.ColumnName);
                        sb.Append("</th>");
                    }
                    sb.Append("</tr>");
                    foreach (DataRow row in dt.Rows)
                    {
                        sb.Append("<tr>");
                        foreach (DataColumn column in dt.Columns)
                        {
                            sb.Append("<td>");
                            sb.Append(row[column]);
                            sb.Append("</td>");
                        }
                        sb.Append("</tr>");
                    }
                    sb.Append("<tr><td align = 'right' colspan = '");
                    sb.Append(dt.Columns.Count - 1);
                    sb.Append("'>Total</td>");
                    sb.Append("<td>");
                    sb.Append(dt.Compute("sum(Total)", ""));
                    sb.Append("</td>");
                    sb.Append("</tr></table>");

                    //Export HTML String as PDF.
                    StringReader sr = new StringReader(sb.ToString());
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=" + CustomerName + "-" + CustomerID + ".pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();
                }
            }
        }
     }
}