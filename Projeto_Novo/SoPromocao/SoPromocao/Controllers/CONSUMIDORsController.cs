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
    public class CONSUMIDORsController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();

        // GET: CONSUMIDORs
        public ActionResult Index()
        {
            return View(db.TB_CONSUMIDOR.ToList());
        }

        // GET: CONSUMIDORs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSUMIDOR cONSUMIDOR = db.TB_CONSUMIDOR.Find(id);
            if (cONSUMIDOR == null)
            {
                return HttpNotFound();
            }
            return View(cONSUMIDOR);
        }

        // GET: CONSUMIDORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CONSUMIDORs/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_CONSUMIDOR,RG_C,NOME,SOBRENOME,EMAIL,SEXO,FRASE_DE_SEGURANCA,SENHA,DATA_DE_NASCIMENTO,ENDERECO,TELEFONE,CIDADE,ESTADO")] CONSUMIDOR cONSUMIDOR)
        {
            if (ModelState.IsValid)
            {
                db.TB_CONSUMIDOR.Add(cONSUMIDOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cONSUMIDOR);
        }

        // GET: CONSUMIDORs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSUMIDOR cONSUMIDOR = db.TB_CONSUMIDOR.Find(id);
            if (cONSUMIDOR == null)
            {
                return HttpNotFound();
            }
            return View(cONSUMIDOR);
        }

        // POST: CONSUMIDORs/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_CONSUMIDOR,RG_C,NOME,SOBRENOME,EMAIL,SEXO,FRASE_DE_SEGURANCA,SENHA,DATA_DE_NASCIMENTO,ENDERECO,TELEFONE,CIDADE,ESTADO")] CONSUMIDOR cONSUMIDOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONSUMIDOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cONSUMIDOR);
        }

        // GET: CONSUMIDORs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSUMIDOR cONSUMIDOR = db.TB_CONSUMIDOR.Find(id);
            if (cONSUMIDOR == null)
            {
                return HttpNotFound();
            }
            return View(cONSUMIDOR);
        }

        // POST: CONSUMIDORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CONSUMIDOR cONSUMIDOR = db.TB_CONSUMIDOR.Find(id);
            db.TB_CONSUMIDOR.Remove(cONSUMIDOR);
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
