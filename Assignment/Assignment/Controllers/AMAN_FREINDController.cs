using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class AMAN_FREINDController : Controller
    {
        private AdventureWorks2017Entities db = new AdventureWorks2017Entities();

        // GET: AMAN_FREIND
        public ActionResult Index()
        {
            return View(db.AMAN_FREIND.ToList());
        }

        // GET: AMAN_FREIND/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AMAN_FREIND aMAN_FREIND = db.AMAN_FREIND.Find(id);
            if (aMAN_FREIND == null)
            {
                return HttpNotFound();
            }
            return View(aMAN_FREIND);
        }

        // GET: AMAN_FREIND/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AMAN_FREIND/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       
        public ActionResult Create([Bind(Include = "Frd_Id,Frd_Name,Frd_Place")] AMAN_FREIND aMAN_FREIND)
        {
            if (ModelState.IsValid)
            {
                db.AMAN_FREIND.Add(aMAN_FREIND);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aMAN_FREIND);
        }

        // GET: AMAN_FREIND/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AMAN_FREIND aMAN_FREIND = db.AMAN_FREIND.Find(id);
            if (aMAN_FREIND == null)
            {
                return HttpNotFound();
            }
            return View(aMAN_FREIND);
        }

        // POST: AMAN_FREIND/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
      
        public ActionResult Edit([Bind(Include = "Frd_Id,Frd_Name,Frd_Place")] AMAN_FREIND aMAN_FREIND)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aMAN_FREIND).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aMAN_FREIND);
        }

        // GET: AMAN_FREIND/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AMAN_FREIND aMAN_FREIND = db.AMAN_FREIND.Find(id);
            if (aMAN_FREIND == null)
            {
                return HttpNotFound();
            }
            return View(aMAN_FREIND);
        }

        // POST: AMAN_FREIND/Delete/5
        [HttpPost, ActionName("Delete")]
       
        public ActionResult DeleteConfirmed(int id)
        {
            AMAN_FREIND aMAN_FREIND = db.AMAN_FREIND.Find(id);
            db.AMAN_FREIND.Remove(aMAN_FREIND);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
