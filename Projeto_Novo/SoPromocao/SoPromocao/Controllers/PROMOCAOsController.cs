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
    public class PROMOCAOsController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();

        // GET: PROMOCAOs
        public ActionResult Index()
        {
            return View(db.TB_PROMOCAO.ToList());
        }

        // GET: PROMOCAOs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROMOCAO pROMOCAO = db.TB_PROMOCAO.Find(id);
            if (pROMOCAO == null)
            {
                return HttpNotFound();
            }
            return View(pROMOCAO);
        }

        // GET: PROMOCAOs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PROMOCAOs/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PROMOCAO,NOME,DETALHES,CATEGORIA,DATA_INICIO,DATA_FIM,VALOR,ESTADO,CIDADE,BAIRRO,RUA,NUMERO,LIMITE_DE_CUPONS")] PROMOCAO pROMOCAO)
        {
            if (ModelState.IsValid)
            {
                db.TB_PROMOCAO.Add(pROMOCAO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pROMOCAO);
        }

        // GET: PROMOCAOs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROMOCAO pROMOCAO = db.TB_PROMOCAO.Find(id);
            if (pROMOCAO == null)
            {
                return HttpNotFound();
            }
            return View(pROMOCAO);
        }

        // POST: PROMOCAOs/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROMOCAO,NOME,DETALHES,CATEGORIA,DATA_INICIO,DATA_FIM,VALOR,ESTADO,CIDADE,BAIRRO,RUA,NUMERO,LIMITE_DE_CUPONS")] PROMOCAO pROMOCAO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pROMOCAO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pROMOCAO);
        }

        // GET: PROMOCAOs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROMOCAO pROMOCAO = db.TB_PROMOCAO.Find(id);
            if (pROMOCAO == null)
            {
                return HttpNotFound();
            }
            return View(pROMOCAO);
        }

        // POST: PROMOCAOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PROMOCAO pROMOCAO = db.TB_PROMOCAO.Find(id);
            db.TB_PROMOCAO.Remove(pROMOCAO);
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
