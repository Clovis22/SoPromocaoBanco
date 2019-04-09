using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SoPromocao.Models;

namespace SoPromocao.Controllers
{
    public class ADMINISTRADORsController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();
       
        // GET: ADMINISTRADORs
        public ActionResult Index()
        {
            return View(db.TB_ADMINISTRADOR.ToList());
        }

        // GET: ADMINISTRADORs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRADOR aDMINISTRADOR = db.TB_ADMINISTRADOR.Find(id);
            if (aDMINISTRADOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRADOR);
        }

        // GET: ADMINISTRADORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ADMINISTRADORs/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ADMINISTRADOR,RG_A,NOME,SOBRENOME,EMAIL,SENHA")] ADMINISTRADOR aDMINISTRADOR)
        {
            if (ModelState.IsValid)
            {
                db.TB_ADMINISTRADOR.Add(aDMINISTRADOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aDMINISTRADOR);
        }

        // GET: ADMINISTRADORs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRADOR aDMINISTRADOR = db.TB_ADMINISTRADOR.Find(id);
            if (aDMINISTRADOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRADOR);
        }

        // POST: ADMINISTRADORs/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ADMINISTRADOR,RG_A,NOME,SOBRENOME,EMAIL,SENHA")] ADMINISTRADOR aDMINISTRADOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aDMINISTRADOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aDMINISTRADOR);
        }

        // GET: ADMINISTRADORs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRADOR aDMINISTRADOR = db.TB_ADMINISTRADOR.Find(id);
            if (aDMINISTRADOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRADOR);
        }

        // POST: ADMINISTRADORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ADMINISTRADOR aDMINISTRADOR = db.TB_ADMINISTRADOR.Find(id);
            db.TB_ADMINISTRADOR.Remove(aDMINISTRADOR);
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
