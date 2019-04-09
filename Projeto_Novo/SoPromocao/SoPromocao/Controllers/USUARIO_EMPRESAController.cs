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
    public class USUARIO_EMPRESAController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();

        // GET: USUARIO_EMPRESA
        public ActionResult Index()
        {
            var tB_USUARIO_EMPRESA = db.TB_USUARIO_EMPRESA.Include(u => u.TB_EMPRESA);
            return View(tB_USUARIO_EMPRESA.ToList());
        }

        // GET: USUARIO_EMPRESA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO_EMPRESA uSUARIO_EMPRESA = db.TB_USUARIO_EMPRESA.Find(id);
            if (uSUARIO_EMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO_EMPRESA);
        }

        // GET: USUARIO_EMPRESA/Create
        public ActionResult Create()
        {
            ViewBag.ID_EMPRESA = new SelectList(db.TB_EMPRESA, "ID_EMPRESA", "BAIRRO");
            return View();
        }

        // POST: USUARIO_EMPRESA/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_USUARIO_EMPRESA,RG_E,NOME,SOBRENOME,EMAIL,SENHA,TELEFONE,ID_EMPRESA")] USUARIO_EMPRESA uSUARIO_EMPRESA)
        {
            if (ModelState.IsValid)
            {
                db.TB_USUARIO_EMPRESA.Add(uSUARIO_EMPRESA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_EMPRESA = new SelectList(db.TB_EMPRESA, "ID_EMPRESA", "BAIRRO", uSUARIO_EMPRESA.ID_EMPRESA);
            return View(uSUARIO_EMPRESA);
        }

        // GET: USUARIO_EMPRESA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO_EMPRESA uSUARIO_EMPRESA = db.TB_USUARIO_EMPRESA.Find(id);
            if (uSUARIO_EMPRESA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_EMPRESA = new SelectList(db.TB_EMPRESA, "ID_EMPRESA", "BAIRRO", uSUARIO_EMPRESA.ID_EMPRESA);
            return View(uSUARIO_EMPRESA);
        }

        // POST: USUARIO_EMPRESA/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_USUARIO_EMPRESA,RG_E,NOME,SOBRENOME,EMAIL,SENHA,TELEFONE,ID_EMPRESA")] USUARIO_EMPRESA uSUARIO_EMPRESA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSUARIO_EMPRESA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_EMPRESA = new SelectList(db.TB_EMPRESA, "ID_EMPRESA", "BAIRRO", uSUARIO_EMPRESA.ID_EMPRESA);
            return View(uSUARIO_EMPRESA);
        }

        // GET: USUARIO_EMPRESA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO_EMPRESA uSUARIO_EMPRESA = db.TB_USUARIO_EMPRESA.Find(id);
            if (uSUARIO_EMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO_EMPRESA);
        }

        // POST: USUARIO_EMPRESA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            USUARIO_EMPRESA uSUARIO_EMPRESA = db.TB_USUARIO_EMPRESA.Find(id);
            db.TB_USUARIO_EMPRESA.Remove(uSUARIO_EMPRESA);
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
