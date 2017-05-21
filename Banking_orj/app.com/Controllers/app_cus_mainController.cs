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
    public class app_cus_mainController : Controller
    {
        private _DbContext db = new _DbContext();
        //private ICusRepository _repository;
        public app_cus_mainController()
        {
         //   _repository = repository;
        }
 
        // GET: app_cus_main
        public async Task<ActionResult> Index()
        {
            var app_cus_main = db.app_cus_main.Include(a => a.app_age_cate).Include(a => a.app_branch).Include(a => a.app_cus_contact).Include(a => a.app_cus_doc).Include(a => a.app_cus_other_info).Include(a => a.app_cus_type).Include(a => a.app_kin_details).Include(a => a.app_occupation).Include(a => a.app_rel_office);
            return View(await app_cus_main.ToListAsync());
        }

        // GET: app_cus_main/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_cus_main app_cus_main = await db.app_cus_main.FindAsync(id);
            if (app_cus_main == null)
            {
                return HttpNotFound();
            }
            return View(app_cus_main);
        }

        // GET: app_cus_main/Create
        public ActionResult Create()
        {
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "age_code");
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name");
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number");
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name");
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code");
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "cus_type_code");
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code");
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "occ_code");
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "rel_code");
            //ViewBag.title = new SelectList(db.app_rel_office, "id", "rel_code");
            return View();
        }
        //check fo customer duplicates
        public bool CheckCustomer(int gender, string firstname_, string lastname, string surname, DateTime dob, string vId, string tel)
        {
            var getReults = db.app_cus_main
                        .Include("app_cus_contact")
                           .Include("app_cus_other_info")
                //.Include("app_cus_type")
                //.Include("app_rel_office")
                //.Include("app_kin_details")
                           .Where(x => x.gender == gender && x.firstname == firstname_
                               && x.lastname == lastname && x.middlename == surname
                               && x.dob == dob && x.app_cus_other_info.verification_id == vId
                               && x.app_cus_contact.tele_number == tel).FirstOrDefault();
            if (getReults != null)
                return true;
            else
                return false;
            //return true;
        }
        // POST: app_cus_main/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,cus_type_code,bran_code,rel_off_code,title,firstname,lastname,middlename,dob,age_cat_type_code,gender,occupation_code,img_url,sign_img_url,marital_status,child_num,home_type_code,cus_since,cus_other_code,kin_details_code,contact_code,cus_doc_code,credit_limit,created_by,modified_by,deleted_by,created_date,modified_date,deleted_date")] app_cus_main app_cus_main)
        {

            var results = CheckCustomer(app_cus_main.gender, app_cus_main.firstname ,app_cus_main.lastname , app_cus_main.middlename, app_cus_main.dob , app_cus_main.app_cus_other_info.verification_id ,app_cus_main.app_cus_contact.tele_number);

            if (results)
            {
                ModelState.AddModelError(string.Empty,"Customer Already Exist");
            }
 
            if (ModelState.IsValid)
            {
                db.app_cus_main.Add(app_cus_main);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "age_code", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "cus_type_code", app_cus_main.cus_type_code);
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "occ_code", app_cus_main.occupation_code);
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "rel_code", app_cus_main.rel_off_code);
            return View(app_cus_main);
        }

        // GET: app_cus_main/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_cus_main app_cus_main = await db.app_cus_main.FindAsync(id);
            if (app_cus_main == null)
            {
                return HttpNotFound();
            }
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "age_code", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "cus_type_code", app_cus_main.cus_type_code);
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "occ_code", app_cus_main.occupation_code);
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "rel_code", app_cus_main.rel_off_code);
            return View(app_cus_main);
        }

        // POST: app_cus_main/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,cus_type_code,bran_code,rel_off_code,title,firstname,lastname,middlename,dob,age_cat_type_code,gender,occupation_code,img_url,sign_img_url,marital_status,child_num,home_type_code,cus_since,cus_other_code,kin_details_code,contact_code,cus_doc_code,credit_limit,created_by,modified_by,deleted_by,created_date,modified_date,deleted_date")] app_cus_main app_cus_main)
        {
            if (ModelState.IsValid)
            {
                db.Entry(app_cus_main).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "age_code", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "cus_type_code", app_cus_main.cus_type_code);
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "occ_code", app_cus_main.occupation_code);
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "rel_code", app_cus_main.rel_off_code);
            return View(app_cus_main);
        }

        // GET: app_cus_main/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_cus_main app_cus_main = await db.app_cus_main.FindAsync(id);
            if (app_cus_main == null)
            {
                return HttpNotFound();
            }
            return View(app_cus_main);
        }

        // POST: app_cus_main/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            app_cus_main app_cus_main = await db.app_cus_main.FindAsync(id);
            db.app_cus_main.Remove(app_cus_main);
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
