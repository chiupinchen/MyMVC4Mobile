using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC4Mobile.Areas.Mobile.Controllers
{
    public class CIController : Controller
    {
        //
        // GET: /Mobile/CI/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Mobile/CI/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Mobile/CI/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Mobile/CI/Create

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

        //
        // GET: /Mobile/CI/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Mobile/CI/Edit/5

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

        //
        // GET: /Mobile/CI/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Mobile/CI/Delete/5

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
