using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SlijterijApp.Models;
using SlijterijApp.SlijterijDB;

namespace SlijterijApp.Controllers
{
    public class WhiskeyController : Controller
    {
        private SlijterijContext db = new SlijterijContext();

        // GET: Whiskey
        public ActionResult Index()
        {
            return View(db.Whiskeys.ToList());
        }

        // GET: Whiskey/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhiskeyModel whiskeyModel = db.Whiskeys.Find(id);
            if (whiskeyModel == null)
            {
                return HttpNotFound();
            }
            return View(whiskeyModel);
        }

        // GET: Whiskey/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Whiskey/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Age,Region,AlcoholPercentage,Type,Label,AvalableAmount")] WhiskeyModel whiskeyModel)
        {
            if (ModelState.IsValid)
            {
                db.Whiskeys.Add(whiskeyModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(whiskeyModel);
        }

        // GET: Whiskey/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhiskeyModel whiskeyModel = db.Whiskeys.Find(id);
            if (whiskeyModel == null)
            {
                return HttpNotFound();
            }
            return View(whiskeyModel);
        }

        // POST: Whiskey/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Age,Region,AlcoholPercentage,Type,Label,AvalableAmount")] WhiskeyModel whiskeyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(whiskeyModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(whiskeyModel);
        }

        // GET: Whiskey/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhiskeyModel whiskeyModel = db.Whiskeys.Find(id);
            if (whiskeyModel == null)
            {
                return HttpNotFound();
            }
            return View(whiskeyModel);
        }

        // POST: Whiskey/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WhiskeyModel whiskeyModel = db.Whiskeys.Find(id);
            db.Whiskeys.Remove(whiskeyModel);
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
