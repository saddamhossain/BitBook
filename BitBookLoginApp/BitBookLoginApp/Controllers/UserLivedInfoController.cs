using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BitBookLoginApp.Models;

namespace BitBookLoginApp.Controllers
{
    public class UserLivedInfoController : Controller
    {
        private BitBookDbContext db = new BitBookDbContext();

        // GET: /UserLivedInfo/
        public ActionResult Index()
        {
            return View(db.UserLivedInfos.ToList());
        }

        // GET: /UserLivedInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLivedInfo userlivedinfo = db.UserLivedInfos.Find(id);
            if (userlivedinfo == null)
            {
                return HttpNotFound();
            }
            return View(userlivedinfo);
        }

        // GET: /UserLivedInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /UserLivedInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,HomeTown,Division,Country")] UserLivedInfo userlivedinfo)
        {
            if (ModelState.IsValid)
            {
                db.UserLivedInfos.Add(userlivedinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userlivedinfo);
        }

        // GET: /UserLivedInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLivedInfo userlivedinfo = db.UserLivedInfos.Find(id);
            if (userlivedinfo == null)
            {
                return HttpNotFound();
            }
            return View(userlivedinfo);
        }

        // POST: /UserLivedInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,HomeTown,Division,Country")] UserLivedInfo userlivedinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userlivedinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userlivedinfo);
        }

        // GET: /UserLivedInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLivedInfo userlivedinfo = db.UserLivedInfos.Find(id);
            if (userlivedinfo == null)
            {
                return HttpNotFound();
            }
            return View(userlivedinfo);
        }

        // POST: /UserLivedInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserLivedInfo userlivedinfo = db.UserLivedInfos.Find(id);
            db.UserLivedInfos.Remove(userlivedinfo);
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
