using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Linq_CRUD.Controllers
{
    public class empCRUDController : Controller
    {
        // GET: empCRUD
        public ActionResult Index()
        {
            return View();
        }

        // GET: empCRUD/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: empCRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: empCRUD/Create
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

        // GET: empCRUD/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: empCRUD/Edit/5
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

        // GET: empCRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: empCRUD/Delete/5
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
