using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasicApp.Models;

namespace MVCBasicApp.Controllers
{
        public class FrameController : Controller
    {
        
        // GET: Frame
        public ActionResult Index()
        {
            // return View();
            return View(new ItemDatabase()); //Return different view than default view           
            
        }

        // GET: Frame/Details/5
        public ActionResult Details(int id)
        {
            var item = new ItemDatabase().FirstOrDefault();
            return View(item);
        }

        // GET: Frame/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Frame/Create
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

        // GET: Frame/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Frame/Edit/5
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

        // GET: Frame/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Frame/Delete/5
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
