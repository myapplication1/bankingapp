using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using app.com.Data;

namespace app.com.Controllers.cus
{
    public class app_countriesController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: app_countries
        public async Task<ActionResult> Index()
        {
            return View(await db.app_countries.ToListAsync());
        }

        // GET: app_countries/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_countries app_countries = await db.app_countries.FindAsync(id);
            if (app_countries == null)
            {
                return HttpNotFound();
            }
            return View(app_countries);
        }

        // GET: app_countries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: app_countries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,name")] app_countries app_countries)
        {
            if (ModelState.IsValid)
            {
                db.app_countries.Add(app_countries);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(app_countries);
        }

        // GET: app_countries/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_countries app_countries = await db.app_countries.FindAsync(id);
            if (app_countries == null)
            {
                return HttpNotFound();
            }
            return View(app_countries);
        }

        // POST: app_countries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,name")] app_countries app_countries)
        {
            if (ModelState.IsValid)
            {
                db.Entry(app_countries).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(app_countries);
        }

        // GET: app_countries/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_countries app_countries = await db.app_countries.FindAsync(id);
            if (app_countries == null)
            {
                return HttpNotFound();
            }
            return View(app_countries);
        }

        // POST: app_countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            app_countries app_countries = await db.app_countries.FindAsync(id);
            db.app_countries.Remove(app_countries);
            await db.SaveChangesAsync();
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
