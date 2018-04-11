using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.Repositories
{
    public class BrandRepository
    {
      
            public Brand GetBrand(int id)
            {
                try
                {
                    ApplicationDbContext ctx = new ApplicationDbContext();
                    return ctx.Brand.Single(x => x.Id == id);
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }

            public List<Brand> GetBrandList()
            {
                try
                {
                    ApplicationDbContext ctx = new ApplicationDbContext();
                    return ctx.Brand.ToList();
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }

            public void AddBrand(Brand brand)
            {
                try
                {
                    ApplicationDbContext ctx = new ApplicationDbContext();
                    ctx.Brand.Add(brand);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }

            public void DeleteBrand(int id)
            {
                try
                {
                    ApplicationDbContext ctx = new ApplicationDbContext();
                    var bra = ctx.Brand.Single(x => x.Id == id);
                    ctx.Brand.Remove(bra);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }
}