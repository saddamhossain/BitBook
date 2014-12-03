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
    public class UserWorkAndStudyInfoController : Controller
    {
        private BitBookDbContext db = new BitBookDbContext();

        // GET: /UserWorkAndStudyInfo/
        public ActionResult Index()
        {
            return View(db.UserWorkAndStudyInfos.ToList());
        }

        // GET: /UserWorkAndStudyInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserWorkAndStudyInfo userworkandstudyinfo = db.UserWorkAndStudyInfos.Find(id);
            if (userworkandstudyinfo == null)
            {
                return HttpNotFound();
            }
            return View(userworkandstudyinfo);
        }

        // GET: /UserWorkAndStudyInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /UserWorkAndStudyInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,WorkStation,ProfessionalSkill,University,College,HighSchool")] UserWorkAndStudyInfo userworkandstudyinfo)
        {
            if (ModelState.IsValid)
            {
                db.UserWorkAndStudyInfos.Add(userworkandstudyinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userworkandstudyinfo);
        }

        // GET: /UserWorkAndStudyInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserWorkAndStudyInfo userworkandstudyinfo = db.UserWorkAndStudyInfos.Find(id);
            if (userworkandstudyinfo == null)
            {
                return HttpNotFound();
            }
            return View(userworkandstudyinfo);
        }

        // POST: /UserWorkAndStudyInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,WorkStation,ProfessionalSkill,University,College,HighSchool")] UserWorkAndStudyInfo userworkandstudyinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userworkandstudyinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userworkandstudyinfo);
        }

        // GET: /UserWorkAndStudyInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserWorkAndStudyInfo userworkandstudyinfo = db.UserWorkAndStudyInfos.Find(id);
            if (userworkandstudyinfo == null)
            {
                return HttpNotFound();
            }
            return View(userworkandstudyinfo);
        }

        // POST: /UserWorkAndStudyInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserWorkAndStudyInfo userworkandstudyinfo = db.UserWorkAndStudyInfos.Find(id);
            db.UserWorkAndStudyInfos.Remove(userworkandstudyinfo);
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
