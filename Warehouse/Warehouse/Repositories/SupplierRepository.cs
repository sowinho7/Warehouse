using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.Repositories
{
    public class SupplierRepository
    {
        public Suppliers GetSupplier(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Suppliers.Single(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public List<Suppliers> GetSuppliersList()
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Suppliers.ToList();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void AddSupplier(Suppliers supplier)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Suppliers.Add(supplier);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void DeleteSupplier(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var supp=ctx.Suppliers.Single(x => x.Id == id);
                ctx.Suppliers.Remove(supp);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void EditSupplier(int id,Suppliers supp)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var oldsupp = ctx.Suppliers.Single(x => x.Id == id);
                oldsupp.Name = supp.Name;
                oldsupp.Country = supp.Country;
                oldsupp.City = supp.City;
                oldsupp.Address = supp.Address;
                oldsupp.AccNo = supp.AccNo;
                oldsupp.ZipCode = supp.ZipCode;
                oldsupp.TaxNo = oldsupp.TaxNo;
                ctx.SaveChanges();
            }
            catch(Exception e)
            {
                throw (e);
            }
        }

    }
}