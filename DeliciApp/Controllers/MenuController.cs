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
    public class MenuController : Controller
    {

        MenuBL menu = new MenuBL();

        // GET: Menu
        public ActionResult Index()
        {
            MenuBD menu = new MenuBD();
            ModelState.Clear();
            return View(menu.Listar());
        }

        // GET: Menu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menu/Create
        [HttpPost]
        public ActionResult Create(ClassMenu menu)
        {
            
                return View();
            

        }

        // GET: Menu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Menu/Edit/5
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

        // GET: Menu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Menu/Delete/5
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
