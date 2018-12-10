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
    public class TypeRestController : Controller
    {
        TypeRestBL mbl = new TypeRestBL();
        // GET: TypeRest
        public ActionResult Index()
        {
            return View();
        }

        // GET: TypeRest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TypeRest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeRest/Create
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

        // GET: TypeRest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TypeRest/Edit/5
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

        // GET: TypeRest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TypeRest/Delete/5
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
