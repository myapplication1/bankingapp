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

namespace app.com.Controllers
{
    public class app_cus_contactController : Controller
    {
        private _DbContext db = new _DbContext();

        // GET: app_cus_contact
        public async Task<ActionResult> Index()
        {
            return View(await db.app_cus_contact.ToListAsync());
        }

        // GET: app_cus_contact/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_cus_contact app_cus_contact = await db.app_cus_contact.FindAsync(id);
            if (app_cus_contact == null)
            {
                return HttpNotFound();
            }
            return View(app_cus_contact);
        }

        // GET: app_cus_contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: app_cus_contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,contact_code,tele_number,fax,email,address1,address2,city,state,zip,brief_location,gps_cordinates")] app_cus_contact app_cus_contact)
        {
            if (ModelState.IsValid)
            {
                db.app_cus_contact.Add(app_cus_contact);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(app_cus_contact);
        }

        // GET: app_cus_contact/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_cus_contact app_cus_contact = await db.app_cus_contact.FindAsync(id);
            if (app_cus_contact == null)
            {
                return HttpNotFound();
            }
            return View(app_cus_contact);
        }

        // POST: app_cus_contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,country_code,contact_code,tele_number,fax,email,address1,address2,city,state,zip,brief_location,gps_cordinates")] app_cus_contact app_cus_contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(app_cus_contact).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(app_cus_contact);
        }

        // GET: app_cus_contact/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_cus_contact app_cus_contact = await db.app_cus_contact.FindAsync(id);
            if (app_cus_contact == null)
            {
                return HttpNotFound();
            }
            return View(app_cus_contact);
        }

        // POST: app_cus_contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            app_cus_contact app_cus_contact = await db.app_cus_contact.FindAsync(id);
            db.app_cus_contact.Remove(app_cus_contact);
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
