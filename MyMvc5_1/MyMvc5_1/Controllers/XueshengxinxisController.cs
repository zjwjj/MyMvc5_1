using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyMvc5_1.Models;

namespace MyMvc5_1.Controllers
{
    public class XueshengxinxisController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Xueshengxinxis
        public ActionResult Index()
        {
            return View(db.Xueshengxinxis.ToList());
        }

        // GET: Xueshengxinxis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xueshengxinxi xueshengxinxi = db.Xueshengxinxis.Find(id);
            if (xueshengxinxi == null)
            {
                return HttpNotFound();
            }
            return View(xueshengxinxi);
        }

        // GET: Xueshengxinxis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Xueshengxinxis/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Xueshengxuehao,Xueshengxingming,Xueshengxingbie")] Xueshengxinxi xueshengxinxi)
        {
            if (ModelState.IsValid)
            {
                db.Xueshengxinxis.Add(xueshengxinxi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(xueshengxinxi);
        }

        // GET: Xueshengxinxis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xueshengxinxi xueshengxinxi = db.Xueshengxinxis.Find(id);
            if (xueshengxinxi == null)
            {
                return HttpNotFound();
            }
            return View(xueshengxinxi);
        }

        // POST: Xueshengxinxis/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Xueshengxuehao,Xueshengxingming,Xueshengxingbie")] Xueshengxinxi xueshengxinxi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xueshengxinxi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(xueshengxinxi);
        }

        // GET: Xueshengxinxis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xueshengxinxi xueshengxinxi = db.Xueshengxinxis.Find(id);
            if (xueshengxinxi == null)
            {
                return HttpNotFound();
            }
            return View(xueshengxinxi);
        }

        // POST: Xueshengxinxis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Xueshengxinxi xueshengxinxi = db.Xueshengxinxis.Find(id);
            db.Xueshengxinxis.Remove(xueshengxinxi);
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
