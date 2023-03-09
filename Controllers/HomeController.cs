using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;


namespace Project.Controllers
{
    public class HomeController : Controller
    {
        ServiceContext db = new ServiceContext();
        // GET: Home
        public ActionResult Index()
        {
            var Data = db.emp.ToList();
            return View(Data);
            //return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Nim e)
        {
            if (ModelState.IsValid == true)
            {
                db.emp.Add(e);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.CreateMessage = ("<script>alert('Data Saved...')</script>");
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.CreateMessage = ("<script>alert('Data Not Saved...')</script>");
                }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.emp.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Nim e)
        {
            db.Entry(e).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                // ViewBag.UpdateMessage = ("<script>alert('Data Saved...')</script>");
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.UpdateMessage = ("<script>alert('Data Not Modified...')</script>");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var row = db.emp.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Delete(Nim e)
        {
            db.Entry(e).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.DeleteMessage = ("<script>alert('Data Deleted ...')</script>");
                ModelState.Clear();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.DeleteMessage = ("<script>alert('Data Not Deleted...')</script>");
            }
            return View();
        }
    }

}