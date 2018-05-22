using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.Repositories
{
    public class ProductRepository
    {
        public Product GetProduct(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Product.Single(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public List<Product> GetProductList()
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Product.ToList();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public IEnumerable<Product> GetProductList(string search)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var products = ctx.Product.Where(x => x.Name.Contains(search));
                return products;
            }
            catch(Exception e)
            {
                throw (e);
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Product.Add(product);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var prod = ctx.Product.Single(x => x.Id == id);
                ctx.Product.Remove(prod);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}