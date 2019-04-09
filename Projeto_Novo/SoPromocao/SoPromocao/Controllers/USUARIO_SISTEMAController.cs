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
    public class USUARIO_SISTEMAController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();

        // GET: USUARIO_SISTEMA
        public ActionResult Index()
        {
            var tB_USUARIO_SISTEMA = db.TB_USUARIO_SISTEMA.Include(u => u.TB_ADMINISTRADOR).Include(u => u.TB_CONSUMIDOR).Include(u => u.TB_USUARIO_EMPRESA);
            return View(tB_USUARIO_SISTEMA.ToList());
        }

        // GET: USUARIO_SISTEMA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO_SISTEMA uSUARIO_SISTEMA = db.TB_USUARIO_SISTEMA.Find(id);
            if (uSUARIO_SISTEMA == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO_SISTEMA);
        }

        // GET: USUARIO_SISTEMA/Create
        public ActionResult Create()
        {
            ViewBag.ID_ADMINISTRADOR = new SelectList(db.TB_ADMINISTRADOR, "ID_ADMINISTRADOR", "NOME");
            ViewBag.ID_CONSUMIDOR = new SelectList(db.TB_CONSUMIDOR, "ID_CONSUMIDOR", "NOME");
            ViewBag.ID_USUARIO_EMPRESA = new SelectList(db.TB_USUARIO_EMPRESA, "ID_USUARIO_EMPRESA", "NOME");
            return View();
        }

        // POST: USUARIO_SISTEMA/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_CONSUMIDOR,ID_ADMINISTRADOR,ID_USUARIO_EMPRESA")] USUARIO_SISTEMA uSUARIO_SISTEMA)
        {
            if (ModelState.IsValid)
            {
                db.TB_USUARIO_SISTEMA.Add(uSUARIO_SISTEMA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ADMINISTRADOR = new SelectList(db.TB_ADMINISTRADOR, "ID_ADMINISTRADOR", "NOME", uSUARIO_SISTEMA.ID_ADMINISTRADOR);
            ViewBag.ID_CONSUMIDOR = new SelectList(db.TB_CONSUMIDOR, "ID_CONSUMIDOR", "NOME", uSUARIO_SISTEMA.ID_CONSUMIDOR);
            ViewBag.ID_USUARIO_EMPRESA = new SelectList(db.TB_USUARIO_EMPRESA, "ID_USUARIO_EMPRESA", "NOME", uSUARIO_SISTEMA.ID_USUARIO_EMPRESA);
            return View(uSUARIO_SISTEMA);
        }

        // GET: USUARIO_SISTEMA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO_SISTEMA uSUARIO_SISTEMA = db.TB_USUARIO_SISTEMA.Find(id);
            if (uSUARIO_SISTEMA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ADMINISTRADOR = new SelectList(db.TB_ADMINISTRADOR, "ID_ADMINISTRADOR", "NOME", uSUARIO_SISTEMA.ID_ADMINISTRADOR);
            ViewBag.ID_CONSUMIDOR = new SelectList(db.TB_CONSUMIDOR, "ID_CONSUMIDOR", "NOME", uSUARIO_SISTEMA.ID_CONSUMIDOR);
            ViewBag.ID_USUARIO_EMPRESA = new SelectList(db.TB_USUARIO_EMPRESA, "ID_USUARIO_EMPRESA", "NOME", uSUARIO_SISTEMA.ID_USUARIO_EMPRESA);
            return View(uSUARIO_SISTEMA);
        }

        // POST: USUARIO_SISTEMA/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_CONSUMIDOR,ID_ADMINISTRADOR,ID_USUARIO_EMPRESA")] USUARIO_SISTEMA uSUARIO_SISTEMA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSUARIO_SISTEMA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ADMINISTRADOR = new SelectList(db.TB_ADMINISTRADOR, "ID_ADMINISTRADOR", "NOME", uSUARIO_SISTEMA.ID_ADMINISTRADOR);
            ViewBag.ID_CONSUMIDOR = new SelectList(db.TB_CONSUMIDOR, "ID_CONSUMIDOR", "NOME", uSUARIO_SISTEMA.ID_CONSUMIDOR);
            ViewBag.ID_USUARIO_EMPRESA = new SelectList(db.TB_USUARIO_EMPRESA, "ID_USUARIO_EMPRESA", "NOME", uSUARIO_SISTEMA.ID_USUARIO_EMPRESA);
            return View(uSUARIO_SISTEMA);
        }

        // GET: USUARIO_SISTEMA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO_SISTEMA uSUARIO_SISTEMA = db.TB_USUARIO_SISTEMA.Find(id);
            if (uSUARIO_SISTEMA == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO_SISTEMA);
        }

        // POST: USUARIO_SISTEMA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            USUARIO_SISTEMA uSUARIO_SISTEMA = db.TB_USUARIO_SISTEMA.Find(id);
            db.TB_USUARIO_SISTEMA.Remove(uSUARIO_SISTEMA);
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
