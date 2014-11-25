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
    public class 教师Controller : Controller
    {
        private SIMNewsContext db = new SIMNewsContext();

        // GET: 教师
        public ActionResult Index()
        {
            return View(db.教师.OrderBy(t => t.工号).ToList());
        }

        // GET: 教师/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            教师 教师 = db.教师.Find(id);
            if (教师 == null)
            {
                return HttpNotFound();
            }
            return View(教师);
        }

        // GET: 教师/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 教师/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "工号,姓名,性别,出生日期,所在系部,职称,个人简介,职务,邮箱,办公电话,家庭电话,手机,角色")] 教师 教师)
        {
            if (ModelState.IsValid)
            {
                db.教师.Add(教师);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(教师);
        }

        // GET: 教师/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            教师 教师 = db.教师.Find(id);
            if (教师 == null)
            {
                return HttpNotFound();
            }
            return View(教师);
        }

        // POST: 教师/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "工号,姓名,性别,出生日期,所在系部,职称,个人简介,职务,邮箱,办公电话,家庭电话,手机,角色")] 教师 教师)
        {
            if (ModelState.IsValid)
            {
                db.Entry(教师).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(教师);
        }

        // GET: 教师/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            教师 教师 = db.教师.Find(id);
            if (教师 == null)
            {
                return HttpNotFound();
            }
            return View(教师);
        }

        // POST: 教师/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            教师 教师 = db.教师.Find(id);
            db.教师.Remove(教师);
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
