using ClothBazar.Entities;
using ClothBazar.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
   public class ProductsService
    {
        public void SaveProducts(Product products)
        {
            using (var context = new CBContext())
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new CBContext())
            {
                return context.Products.ToList();
            }
           
        }
        public Product GetProduct(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Products.Find(ID);
            }

        }
        public void UpdateProduct(Product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;    
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int ID)
        {
            using (var context = new CBContext())
            {
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
