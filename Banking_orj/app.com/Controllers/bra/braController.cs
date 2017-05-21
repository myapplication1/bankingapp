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

namespace app.com.Controllers.bra
{
    public class braController : Controller
    {
        private _DbContext db = new _DbContext();

        // GET: app_branch
        public async Task<ActionResult> Index()
        {
            var app_branch = db.app_branch.Include(a => a.app_bran_type);
            return View(await app_branch.ToListAsync());
        }

        // GET: app_branch/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_branch app_branch = await db.app_branch.FindAsync(id);
            if (app_branch == null)
            {
                return HttpNotFound();
            }
            return View(app_branch);
        }

        // GET: app_branch/Create
        public ActionResult Create()
        {
            ViewBag.bran_type_code = new SelectList(db.app_bran_type, "id", "name");
            return View();
        }

        // POST: app_branch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,bran_code,branch_name,bran_type_code,address1,address2,state,zip,assets")] app_branch app_branch)
        
        {
            ViewBag.alert = "";

            //var ck = _repository.CheckCustomer(app_cus_main.gender, app_cus_main.firstname, app_cus_main.lastname, app_cus_main.middlename, app_cus_main.dob, app_cus_other_info.verification_id, app_cus_contact.tele_number);


            //if (ck)
            //{
            //    ModelState.AddModelError("", "Branch Already exist");
            //}



            if (ModelState.IsValid)
            {

                db.app_branch.Add(app_branch);
                await db.SaveChangesAsync();
                ViewBag.alert = "saved";
                return RedirectToAction("Index");
            }
            else
            { ViewBag.alert = "error"; }

            var errors = ModelState.Values.SelectMany(v => v.Errors);
            ViewBag.bran_type_code = new SelectList(db.app_bran_type, "id", "name", app_branch.bran_type_code);
            return View(app_branch);

           
        }

        // GET: app_branch/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_branch app_branch = await db.app_branch.FindAsync(id);
            if (app_branch == null)
            {
                return HttpNotFound();
            }
            ViewBag.bran_type_code = new SelectList(db.app_bran_type, "id", "name", app_branch.bran_type_code);
            return View(app_branch);
        }

        // POST: app_branch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,bran_code,branch_name,bran_type_code,address1,address2,state,zip,assets")] app_branch app_branch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(app_branch).State = EntityState.Modified;
                await db.SaveChangesAsync();
                ViewBag.alert = "saved";
                return RedirectToAction("Index");
              
               // return RedirectToAction("Index");
            }
            else
            { ViewBag.alert = "error"; }

            var errors = ModelState.Values.SelectMany(v => v.Errors);
            ViewBag.bran_type_code = new SelectList(db.app_bran_type, "id", "name", app_branch.bran_type_code);
            return View(app_branch);

            //if (ModelState.IsValid)
            //{
            //    db.Entry(app_branch).State = EntityState.Modified;
            //    await db.SaveChangesAsync();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.bran_type_code = new SelectList(db.app_bran_type, "id", "name", app_branch.bran_type_code);
            //return View(app_branch);
        }

        // GET: app_branch/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_branch app_branch = await db.app_branch.FindAsync(id);
            if (app_branch == null)
            {
                return HttpNotFound();
            }
            return View(app_branch);
        }

        // POST: app_branch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            app_branch app_branch = await db.app_branch.FindAsync(id);
            db.app_branch.Remove(app_branch);
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
