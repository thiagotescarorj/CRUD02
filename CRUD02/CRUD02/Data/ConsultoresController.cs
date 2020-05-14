using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CrudCadastroCliente.Models;

namespace CrudCadastroCliente.Data
{
    public class ConsultoresController : Controller
    {
        private CrudCadastroClienteContext db = new CrudCadastroClienteContext();

        // GET: Consultores
        public ActionResult Index()
        {
            return View(db.Consultors.ToList());
        }

        // GET: Consultores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultor consultor = db.Consultors.Find(id);
            if (consultor == null)
            {
                return HttpNotFound();
            }
            return View(consultor);
        }

        // GET: Consultores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] Consultor consultor)
        {
            if (ModelState.IsValid)
            {
                db.Consultors.Add(consultor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consultor);
        }

        // GET: Consultores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultor consultor = db.Consultors.Find(id);
            if (consultor == null)
            {
                return HttpNotFound();
            }
            return View(consultor);
        }

        // POST: Consultores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] Consultor consultor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consultor);
        }

        // GET: Consultores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultor consultor = db.Consultors.Find(id);
            if (consultor == null)
            {
                return HttpNotFound();
            }
            return View(consultor);
        }

        // POST: Consultores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Consultor consultor = db.Consultors.Find(id);
            db.Consultors.Remove(consultor);
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
