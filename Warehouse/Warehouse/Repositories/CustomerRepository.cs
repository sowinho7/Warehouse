using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.Repositories
{
    public class CustomerRepository
    {
        public Customers GetCustomer(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Customers.Single(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public List<Customers> GetCustomersList()
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Customers.ToList();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void AddCustomer(Customers customer)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Customers.Add(customer);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void DeleteCustomer(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var cust = ctx.Customers.Single(x => x.Id == id);
                ctx.Customers.Remove(cust);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}