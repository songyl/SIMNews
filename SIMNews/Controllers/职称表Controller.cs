using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SIMNews.Models;

namespace SIMNews.Controllers
{
    public class 职称表Controller : Controller
    {
        private SIMNewsContext db = new SIMNewsContext();

        // GET: 职称表
        public ActionResult Index()
        {
            return View(db.职称表.ToList());
        }

        // GET: 职称表/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            职称表 职称表 = db.职称表.Find(id);
            if (职称表 == null)
            {
                return HttpNotFound();
            }
            return View(职称表);
        }

        // GET: 职称表/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 职称表/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,职称,级别")] 职称表 职称表)
        {
            if (ModelState.IsValid)
            {
                db.职称表.Add(职称表);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(职称表);
        }

        // GET: 职称表/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            职称表 职称表 = db.职称表.Find(id);
            if (职称表 == null)
            {
                return HttpNotFound();
            }
            return View(职称表);
        }

        // POST: 职称表/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,职称,级别")] 职称表 职称表)
        {
            if (ModelState.IsValid)
            {
                db.Entry(职称表).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(职称表);
        }

        // GET: 职称表/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            职称表 职称表 = db.职称表.Find(id);
            if (职称表 == null)
            {
                return HttpNotFound();
            }
            return View(职称表);
        }

        // POST: 职称表/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            职称表 职称表 = db.职称表.Find(id);
            db.职称表.Remove(职称表);
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
