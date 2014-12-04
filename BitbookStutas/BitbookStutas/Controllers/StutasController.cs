using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BitbookStutas.Models;
using BitbookStutas.Context;

namespace BitbookStutas.Controllers
{
    public class StutasController : Controller
    {
        private StutasContext db = new StutasContext();

        // GET: /Stutas/
        public ActionResult Index()
        {
            return View(db.Stutases.ToList());
        }

        // GET: /Stutas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stutas stutas = db.Stutases.Find(id);
            if (stutas == null)
            {
                return HttpNotFound();
            }
            return View(stutas);
        }

        // GET: /Stutas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Stutas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Stutasis")] Stutas stutas)
        {
          
            if (ModelState.IsValid)
            {
                db.Stutases.Add(stutas);
                //db.Stutases.Add(db.Stutases.ToList());
                db.SaveChanges();


                return View(stutas);
            }

            return View(stutas);
        }

        // GET: /Stutas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stutas stutas = db.Stutases.Find(id);
            if (stutas == null)
            {
                return HttpNotFound();
            }
            return View(stutas);
        }

        // POST: /Stutas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Stutasis")] Stutas stutas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stutas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stutas);
        }

        // GET: /Stutas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stutas stutas = db.Stutases.Find(id);
            if (stutas == null)
            {
                return HttpNotFound();
            }
            return View(stutas);
        }

        // POST: /Stutas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stutas stutas = db.Stutases.Find(id);
            db.Stutases.Remove(stutas);
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
