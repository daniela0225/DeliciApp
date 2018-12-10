using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BL;
using BDAccess;

namespace DeliciApp.Controllers
{
    public class TypeMealController : Controller
    {
        TypeMealBL mbl = new TypeMealBL();
        // GET: TypeMeal
        public ActionResult Index()
        {
            return View();
        }

        // GET: TypeMeal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TypeMeal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeMeal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TypeMeal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TypeMeal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TypeMeal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TypeMeal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
