using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.Repositories
{
    public class InvoiceRepository
    {
        public Invoices GetInvoice(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Invoices.Single(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public List<Invoices> GetInvoiceList()
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Invoices.ToList();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void AddInvoice(Invoices invoice)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Invoices.Add(invoice);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void DeleteInvoice(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var invo = ctx.Invoices.Single(x => x.Id == id);
                ctx.Invoices.Remove(invo);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void EditInvoice(Invoices Invoice, int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var OldInvoice = ctx.Invoices.Single(XmlSiteMapProvider => XmlSiteMapProvider.Id == id);

                OldInvoice.Name = Invoice.Name;
                OldInvoice.Country = Invoice.Country;
                OldInvoice.City = Invoice.City;
                OldInvoice.Address = Invoice.Address;
                OldInvoice.ZipCode = Invoice.ZipCode;
                OldInvoice.ProdName = Invoice.ProdName;
                OldInvoice.Vat = Invoice.Vat;
                OldInvoice.NettoPrice = Invoice.NettoPrice;
                OldInvoice.Count = Invoice.Count;
                OldInvoice.InvoiceNo = Invoice.InvoiceNo;
                OldInvoice.InvoiceDate = Invoice.InvoiceDate;
                OldInvoice.PaymentDate = Invoice.PaymentDate;
                    
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

    }
}