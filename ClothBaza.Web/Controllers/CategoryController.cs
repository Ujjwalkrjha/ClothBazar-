using ClothBazar.Entities;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBaza.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoryservice = new CategoriesService();
        // GET: Category
        public ActionResult Index()
        {
            var categories = categoryservice.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryservice.SaveCategory(category);
            //return View();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryservice.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryservice.UpdateCategory(category);
            //return View(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoryservice.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            //category = categoryservice.GetCategory(category.ID);
            categoryservice.DeleteCategory(category.ID);
            //return View(category);
            return RedirectToAction("Index");
        }
    }
}