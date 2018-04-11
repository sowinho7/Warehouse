using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.Repositories
{
    public class CategoryRepository
    {

        public Category GetCategory(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Category.Single(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public List<Category> GetCategoryList()
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                return ctx.Category.ToList();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public void AddCategory(Category category)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Category.Add(category);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                var cat = ctx.Category.Single(x => x.Id == id);
                ctx.Category.Remove(cat);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}