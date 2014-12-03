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
    public class UserBasicInfoController : Controller
    {
        private BitBookDbContext db = new BitBookDbContext();

        // GET: /UserBasicInfo/
        public ActionResult Index()
        {
            return View(db.UserBasicInfos.ToList());
        }

        // GET: /UserBasicInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBasicInfo userbasicinfo = db.UserBasicInfos.Find(id);
            if (userbasicinfo == null)
            {
                return HttpNotFound();
            }
            return View(userbasicinfo);
        }

        // GET: /UserBasicInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /UserBasicInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,MobileNumber,WebsiteName,Email,BirthDate,Gender,InterestedIn,Language,Relegious,Political")] UserBasicInfo userbasicinfo)
        {
            if (ModelState.IsValid)
            {
                db.UserBasicInfos.Add(userbasicinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userbasicinfo);
        }

        // GET: /UserBasicInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBasicInfo userbasicinfo = db.UserBasicInfos.Find(id);
            if (userbasicinfo == null)
            {
                return HttpNotFound();
            }
            return View(userbasicinfo);
        }

        // POST: /UserBasicInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,MobileNumber,WebsiteName,Email,BirthDate,Gender,InterestedIn,Language,Relegious,Political")] UserBasicInfo userbasicinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userbasicinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userbasicinfo);
        }

        // GET: /UserBasicInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBasicInfo userbasicinfo = db.UserBasicInfos.Find(id);
            if (userbasicinfo == null)
            {
                return HttpNotFound();
            }
            return View(userbasicinfo);
        }

        // POST: /UserBasicInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserBasicInfo userbasicinfo = db.UserBasicInfos.Find(id);
            db.UserBasicInfos.Remove(userbasicinfo);
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
