using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app.com.Data;
using app.com.Models;
using app.com.Extensions;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using AutoMapper;
using System.Data.SqlClient;


namespace app.com.Controllers
{

    public class CusController : Controller
    {
        _DbContext db = new _DbContext();
        private ICusRepository _repository;
        public CusController(ICusRepository repository)
        {
            _repository = repository;
        }

        // GET: app_cus_contact
        public ActionResult Index()
        {
            return  View(_repository.GetAllCustomers(150));
         //   return View(await db.app_cus_contact.ToListAsync());
        }



        public ActionResult EditCustomer(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            app_cus_main app_cus_main = _repository.GetCustomers(id);
            if (app_cus_main == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat",app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
          //  ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.age_cat_type_code);
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.age_cat_type_code);
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "security_group", app_cus_main.age_cat_type_code);
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code );
            ViewBag.gender = new SelectList(db.app_gender, "id", "sex", app_cus_main.gender );
            ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name", app_cus_main.home_type_code);
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "full_name", app_cus_main.kin_details_code);
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code );
            ViewBag.countries = new SelectList(db.app_countries , "id", "name", app_cus_main.app_cus_contact.contact_code );
            ViewBag.kin_type = new SelectList(db.app_kin_type , "id", "kin_type_name", app_cus_main.kin_details_code  );

            //      IEnumerable <SelectListItem> 

            return View(app_cus_main );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomer(app_cus_main app_cus_main)
        {
            if (ModelState.IsValid)
                return View(app_cus_main);
           
            
                app_cus_main.modified_by = _repository.GetLoginUser();
                app_cus_main.modified_date = _repository.GetCurrentDateTime();
                db.Entry(app_cus_main).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Success"] = true;
                return RedirectToAction("Index");

            ViewBag.countries = _repository.GetCountries();
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            //  ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.age_cat_type_code);
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.age_cat_type_code);
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "security_group", app_cus_main.age_cat_type_code);
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code);
            ViewBag.gender = new SelectList(db.app_gender, "id", "sex", app_cus_main.gender);
            ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name", app_cus_main.home_type_code);
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "full_name", app_cus_main.kin_details_code);
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code);

            return View(app_cus_main);
        }




    }
}