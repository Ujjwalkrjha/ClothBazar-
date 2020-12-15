using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothBazar.Services;
using ClothBazar.Entities;

namespace ClothBaza.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductsService productservices = new ProductsService();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productservices.SaveProducts(product);
            //return View();
            return RedirectToAction("Index");
        }
        public ActionResult ProductTable(string search)
        {
            var products = productservices.GetProducts();
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(products);
        }
    }
}