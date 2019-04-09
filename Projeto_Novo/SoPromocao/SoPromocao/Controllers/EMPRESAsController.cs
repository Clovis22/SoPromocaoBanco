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
    public class EMPRESAsController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();

        // GET: EMPRESAs
        public ActionResult Index()
        {
            return View(db.TB_EMPRESA.ToList());
        }

        // GET: EMPRESAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPRESA eMPRESA = db.TB_EMPRESA.Find(id);
            if (eMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(eMPRESA);
        }

        // GET: EMPRESAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPRESAs/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_EMPRESA,CNPJ,BAIRRO,SENHA,FRASE_SEGURANCA,EMAIL,TELEFONE,SOLICITANTE,CIDADE,CEP,NOME,RUA,NUMERO")] EMPRESA eMPRESA)
        {
            if (ModelState.IsValid)
            {
                db.TB_EMPRESA.Add(eMPRESA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eMPRESA);
        }

        // GET: EMPRESAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPRESA eMPRESA = db.TB_EMPRESA.Find(id);
            if (eMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(eMPRESA);
        }

        // POST: EMPRESAs/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_EMPRESA,CNPJ,BAIRRO,SENHA,FRASE_SEGURANCA,EMAIL,TELEFONE,SOLICITANTE,CIDADE,CEP,NOME,RUA,NUMERO")] EMPRESA eMPRESA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMPRESA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eMPRESA);
        }

        // GET: EMPRESAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPRESA eMPRESA = db.TB_EMPRESA.Find(id);
            if (eMPRESA == null)
            {
                return HttpNotFound();
            }
            return View(eMPRESA);
        }

        // POST: EMPRESAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPRESA eMPRESA = db.TB_EMPRESA.Find(id);
            db.TB_EMPRESA.Remove(eMPRESA);
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
