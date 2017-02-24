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
            return View(_repository.GetAllCustomers(150));
            //   return View(await db.app_cus_contact.ToListAsync());
        }



        public async Task<ActionResult> EditCustomer(int? id)
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
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            ViewBag.countries = new SelectList(db.app_countries, "id", "name", app_cus_main.app_cus_contact.contact_code);

            //ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "age_code", "name_of_cat", app_cus_main.age_cat_type_code);
            //ViewBag.gender = new SelectList(db.app_branch, "bran_code", "branch_name", app_cus_main.gender);
            //ViewBag.contact_code = new SelectList(db.app_cus_contact, "contact_code", "tele_number", app_cus_main.contact_code);
            //ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "cus_doc_code", "cus_doc_name", app_cus_main.cus_doc_code);
            //ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "cus_other_code", "verification_id", app_cus_main.cus_other_code);
            //ViewBag.cus_type_code = new SelectList(db.app_cus_type, "cus_type_code", "type_name", app_cus_main.cus_type_code);
            ViewBag.gender = new SelectList(db.app_gender, "gender_code", "sex", app_cus_main.gender);
            //ViewBag.gender = new SelectList(db.app_gender, "gender_code", "sex", app_cus_main.gender);
            ViewBag.home_type_code = new SelectList(db.app_home_type, "home_code", "type_name", app_cus_main.home_type_code);
            //ViewBag.kin_details_code = new SelectList(db.app_kin_details, "kin_details_code", "kin_type_code", app_cus_main.kin_details_code);
            //ViewBag.occupation_code = new SelectList(db.app_occupation, "occ_code", "name", app_cus_main.occupation_code);
            //ViewBag.rel_off_code = new SelectList(db.app_rel_office, "rel_code", "full_name", app_cus_main.rel_off_code);
        


            return View(app_cus_main);
        }

        // GET: app_cus_main/Create
        public ActionResult CreateCustomer()
        {
            ViewBag.gender = new SelectList(db.app_gender, "id", "sex");
            ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name");
            ViewBag.countries = new SelectList(db.app_countries, "id", "name");
            //ViewBag.kin_type = new SelectList(db.app_kin_type, "id", "kin_type_name");

            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat");
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name");
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number");
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name");
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code");
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name");
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code");
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name");
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name");
            return View();
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateCustomer([Bind(Include = "id,bran_code,cus_type_code,title,firstname,lastname,middlename,dob,gender,occupation_code,img_url,sign_img_url,marital_status,child_num,home_type_code,cus_since,cus_doc_code,credit_limit,kin_type_code,created_by,modified_by,deleted_by,created_date,modified_date,deleted_date,rel_off_code")]
                                                      app_cus_main app_cus_main
                                                    , app_cus_other_info app_cus_other_info
                                                    , app_cus_contact app_cus_contact
                                                    , app_kin_details app_kin_details
                                                     )
        {
            if (ModelState.IsValid)
            {                        
                app_cus_main.app_cus_contact = app_cus_contact;
                app_cus_main.app_kin_details = app_kin_details;
                app_cus_main.app_cus_other_info = app_cus_other_info;
                app_cus_main.cus_code =_repository.GetCustomerCode(app_cus_main.id);
                db.app_cus_main.Add(app_cus_main);
                db.app_cus_contact.Add(app_cus_contact);
                db.app_cus_other_info.Add(app_cus_other_info);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
             }

            //var errors = ModelState.Values.SelectMany(v => v.Errors);
            ViewBag.countries = new SelectList(db.app_countries, "id", "name");
            ViewBag.home_type_code = new SelectList(db.app_home_type, "home_code", "type_name", app_cus_main.home_type_code);
            ViewBag.gender = new SelectList(db.app_gender, "gender_code", "sex", app_cus_main.gender);
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code);
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code);
            //ViewBag.countries = new SelectList(db.app_countries, "id", "name", app_cus_main.app_cus_contact.contact_code);

            return View(app_cus_main);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomer(app_cus_main app_cus_main)
        {
            if (ModelState.IsValid)
            //  return View(app_cus_main);
            { 

            app_cus_main.modified_by = _repository.GetLoginUser();
            app_cus_main.modified_date = _repository.GetCurrentDateTime();
            db.Entry(app_cus_main).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Message"] = "Data Saved !!!.";
                return RedirectToAction("Index");
            }
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);

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
            ViewBag.countries = new SelectList(db.app_countries, "id", "name", app_cus_main.app_cus_contact.contact_code);
            //ViewBag.kin_type = new SelectList(db.app_kin_type, "id", "kin_type_name", app_cus_main.kin_details_code);

            return View(app_cus_main);
    }

 
    }
}