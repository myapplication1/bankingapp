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
using app.com.Helpers;
using System.IO;
using System.Data.OleDb;
 using app.com.Data.impp;
//using toastr.Net.OptionEnums;




namespace app.com.Controllers
{

    public class ImpController : Controller
    {
        _DbContext db = new _DbContext();
        private ImpRepository _repository;
        public ImpController(ImpRepository repository)
        {
            _repository = repository;
        }

        // GET: app_cus_contact
        public ActionResult Index()
        {
            return View(_repository.GetAllImports(150));
            //   return View(await db.app_cus_contact.ToListAsync());
        }



        //public ActionResult EditCustomer(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    app_cus_main app_cus_main = _repository.GetCustomers(id);

        //    if (app_cus_main == null)
        //    {
        //        return HttpNotFound();

        //    }
        //    ViewBag.citizenship = new SelectList(db.app_countries, "id", "name");

        //    ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
        //    ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
        //    ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
        //    ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
        //    ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
        //    ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code);
        //    ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
        //    ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
        //    ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code);
        //    ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
        //    ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
        //    ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
        //    ViewBag.countries = new SelectList(db.app_countries, "id", "name", app_cus_main.app_cus_contact.country_code);
        //    ViewBag.gender = new SelectList(db.app_gender, "id", "sex", app_cus_main.gender);
        //    //ViewBag.gender = new SelectList(db.app_gender, "gender_code", "sex", app_cus_main.gender);
        //    ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name", app_cus_main.home_type_code);
        //    //ViewBag.kin_details_code = new SelectList(db.app_kin_details, "kin_details_code", "kin_type_code", app_cus_main.kin_details_code);
        //    //ViewBag.occupation_code = new SelectList(db.app_occupation, "occ_code", "name", app_cus_main.occupation_code);
        //    //ViewBag.rel_off_code = new SelectList(db.app_rel_office, "rel_code", "full_name", app_cus_main.rel_off_code);



        //    return View(app_cus_main);
        //}

        //public ActionResult DelCustomer(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    app_cus_main app_cus_main = _repository.GetCustomers(id);

        //    if (app_cus_main == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
        //    ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
        //    ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
        //    ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
        //    ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
        //    ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code);
        //    ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
        //    ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
        //    ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code);
        //    ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
        //    ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
        //    ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
        //    ViewBag.countries = new SelectList(db.app_countries, "id", "name", app_cus_main.app_cus_contact.country_code);
        //    ViewBag.gender = new SelectList(db.app_gender, "id", "sex", app_cus_main.gender);
        //    //ViewBag.gender = new SelectList(db.app_gender, "gender_code", "sex", app_cus_main.gender);
        //    ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name", app_cus_main.home_type_code);
        //    //ViewBag.kin_details_code = new SelectList(db.app_kin_details, "kin_details_code", "kin_type_code", app_cus_main.kin_details_code);
        //    //ViewBag.occupation_code = new SelectList(db.app_occupation, "occ_code", "name", app_cus_main.occupation_code);
        //    //ViewBag.rel_off_code = new SelectList(db.app_rel_office, "rel_code", "full_name", app_cus_main.rel_off_code);



        //    return View(app_cus_main);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult DelCustomer([Bind(Include = "id,home_type_code,age_cat_type_code,cus_type_code,title,firstname,lastname,middlename,dob,gender,occupation_code,img_url,sign_img_url,marital_status,child_num,cus_since,cus_doc_code,credit_limit,kin_type_code,created_by,modified_by,deleted_by,created_date,modified_date,deleted_date,rel_off_code,bran_code")]
        //                                              app_cus_main app_cus_main
        //                                           , app_cus_other_info app_cus_other_info
        //                                           , app_cus_contact app_cus_contact
        //                                           , app_kin_details app_kin_details
        //   )

        //{
        //    if (ModelState.IsValid)
        //    //  return View(app_cus_main);
        //    {
        //        app_cus_main.modified_by = _repository.GetLoginUser();
        //        app_cus_main.modified_date = _repository.GetCurrentDateTime();
        //        app_cus_main.status = "del";
        //        app_cus_main.app_cus_contact = app_cus_contact;
        //        app_cus_main.app_kin_details = app_kin_details;
        //        app_cus_main.app_cus_other_info = app_cus_other_info;

        //        app_cus_main.cus_code = _repository.GetCustomerCode(app_cus_main.id);
        //        db.app_cus_main.Add(app_cus_main);

        //        db.Entry(app_cus_main).State = EntityState.Modified;
        //        db.SaveChanges();
        //        ViewBag.alert = "saved";
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
        //    ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
        //    ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);

        //    ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
        //    ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
        //    ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
        //    //  ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.age_cat_type_code);
        //    ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.age_cat_type_code);
        //    ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "security_group", app_cus_main.age_cat_type_code);
        //    ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code);
        //    ViewBag.gender = new SelectList(db.app_gender, "id", "sex", app_cus_main.gender);
        //    ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name", app_cus_main.home_type_code);
        //    ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "full_name", app_cus_main.kin_details_code);
        //    ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
        //    ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code);
        //    ViewBag.countries = new SelectList(db.app_countries, "id", "name", app_cus_main.app_cus_contact.contact_code);
        //    //ViewBag.kin_type = new SelectList(db.app_kin_type, "id", "kin_type_name", app_cus_main.kin_details_code);

        //    return View(app_cus_main);
        //}

        public ActionResult DetailsCustomer(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_imp_history app_imp_history = _repository.GetImports(id);

            if (app_imp_history == null)
            {
                return HttpNotFound();
            }
            //ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
            //ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            //ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
            //ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
            //ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
            //ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code);
            //ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
            //ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
            //ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code);
            //ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "email", app_cus_main.contact_code);
            //ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
            //ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            //ViewBag.countries = new SelectList(db.app_countries, "id", "name", app_cus_main.app_cus_contact.country_code);
            //ViewBag.gender = new SelectList(db.app_gender, "id", "sex", app_cus_main.gender);
            ////ViewBag.gender = new SelectList(db.app_gender, "gender_code", "sex", app_cus_main.gender);
            //ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name", app_cus_main.home_type_code);
            ////ViewBag.kin_details_code = new SelectList(db.app_kin_details, "kin_details_code", "kin_type_code", app_cus_main.kin_details_code);
            ////ViewBag.occupation_code = new SelectList(db.app_occupation, "occ_code", "name", app_cus_main.occupation_code);
            ////ViewBag.rel_off_code = new SelectList(db.app_rel_office, "rel_code", "full_name", app_cus_main.rel_off_code);



            return View(app_imp_history);
        }




        public ActionResult DownLoadExcelFile()
        {
            byte[] excelBytes = ExtensionMethods.GetFileData("template_cus_imp.xlsx", Server.MapPath("~/Doc/data_imp"));
            var cd = new System.Net.Mime.ContentDisposition { FileName = "template_cus_imp.xlsx" };
            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(excelBytes, "application/vnd.ms-excel");
        }



        [HttpPost]
        public async Task<ActionResult> CreateImport(app_file model)
        {
            //Chcking if modelState is valid or not.
            if (ModelState.IsValid)
            {
                ViewBag.alert = "";
                //Create an object of Service class.
                //---   UploadService service = new UploadService();
                //Saved the uploaded file details to database.
                //---   string fileGuid = service.SaveFileDetails(model);
                //The file is then saved to physical folder.
                string savedFileName = "~/Doc/" + "_" + "000_imp" + model.File.FileName;
                model.File.SaveAs(Server.MapPath(savedFileName));

                //The below code reads the excel file.
                var connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", Server.MapPath(savedFileName));
                var adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString);
                var ds = new DataSet();
                adapter.Fill(ds, "results");
                DataTable data = ds.Tables["results"];

                //The excel file is validated for data entered in excel file.
                // bool isValid = _repository.ValidateExcelFileData(data);
                // if (isValid)
                // {
                //If the excel file uploaded validates to true then the data mentioned is saved to database.
                foreach (DataRow row in data.Rows)
                {
                    app_cus_main app_cus = new app_cus_main();
                    app_cus_contact app_contact = new app_cus_contact();
                    app_cus_other_info app_info = new app_cus_other_info();
                    app_cus_type app_type = new app_cus_type();
                    app_occupation app_occ = new app_occupation();
                    app_rel_office app_rel = new app_rel_office();
                    app_branch app_bra = new app_branch();
                    app_gender app_gen = new app_gender();


                    app_cus.cus_code = row["CUST_ID"].ToString();
                    app_cus.title = row["TITLE"].ToString();
                    app_cus.firstname = row["FIRST_NAME"].ToString();
                    app_cus.middlename = row["OTHER_NAME"].ToString();
                    app_cus.lastname = row["LAST_NAME"].ToString();

                    //CUSTOMER TYPE
                    //FK app_cus.cus_type_code = Convert.ToInt32(row["CUSTOMER_TYPE"]);
                    app_type.type_name = row["CUSTOMER_TYPE"].ToString();

                    //GENDER
                    app_gen.sex =row["GENDER"].ToString();

                    app_cus.dob = Convert.ToDateTime(row["DATE_BIRTH"]);

                    //contact
                    app_contact.address2 = row["HOUSE_NUMBER"].ToString();
                    app_contact.tele_number = row["TEL_1"].ToString();
                    app_contact.tele_number2 = row["TEL_2"].ToString();
                    app_contact.email = row["EMAIL"].ToString();

                    app_contact.address1 = row["ADDRESS"].ToString();

                    //OTHER INFO
                    app_info.verification_id = row["VERI_ID"].ToString();
                    app_info.security_group = row["SECURITY_GROUP"].ToString();

                    if (row["SECURITY_GROUP"].ToString() == null || row["SECURITY_GROUP"].ToString() == string.Empty)
                    {
                        app_info.security_group = "Public";

                    }


                    //OCCUPATION
                    //FK app_cus.occupation_code = Convert.ToInt32(row["OCCUPATION"]);


                    app_occ.name = row["OCCUPATION"].ToString();

                    app_cus.marital_status = row["MARITAL_STATUS"].ToString();


                    //relations office
                    // app_cus.rel_off_code = Convert.ToInt32(row["GENDER"]);
                    app_cus.rel_off_code =(int)row["REL_ID"];


                    //app_rel.firstname = row["RELATION_OFFICER_FIRSTNAME"].ToString();
                    //app_rel.lastname = row["RELATION_OFFICER_LASTNAME"].ToString();
                    //app_rel.middlename = row["RELATION_OFFICER_OTHERNAME"].ToString();

                    //BRANCH
                    //FK  
                    // app_cus.bran_code =  Convert.ToInt32(row["BRANCH"]);

                    app_bra.branch_name = row["BRANCH"].ToString();


                    //save to db
                    app_cus.created_by = _repository.GetLoginUser();
                    app_cus.created_date = _repository.GetCurrentDateTime();
                    app_cus.cus_since = _repository.GetCurrentDateTime();
                    app_cus.img_url = "/image/photo";
                    app_cus.status = "ini";
                    app_cus.sign_img_url = "/image/signature";

                    
                    app_cus.app_cus_contact= app_contact;
                    app_cus.app_cus_other_info=app_info;
                    app_cus.app_cus_type = app_type;
                    app_cus.app_occupation=app_occ ;
                    app_cus.app_rel_office = app_rel;
                    app_cus.app_branch= app_bra;
                    app_cus.app_gender = app_gen;

                    if (TryValidateModel(app_cus))
                    {
                        var errors = ModelState.Values.SelectMany(v => v.Errors);
        
                        db.app_cus_main.Add(app_cus);
                        ViewBag.alert = "saved";
                        await db.SaveChangesAsync();

                    }
                    else
                    {
                        var errors = ModelState.Values.SelectMany(v => v.Errors);
        
                        ViewBag.alert = "error";
                    return View(app_cus);
                    }

                    //   app_cus_main.cus_code = _repository.GetCustomerCode(app_cus_main.id);

                    //_repository.SaveUserDetails(firstname, lastname, age, email, password);
                }
                return View("Index");
                //  _repository.UpdateExcelStatus(Guid.Parse(fileGuid), true, string.Empty);
                // }
                // else
                //  {
                // _repository.UpdateExcelStatus(Guid.Parse(fileGuid), true, "Failure");
                //  }

            }
            else
            {
                return View(model);
            }
        }
           
            //return RedirectToAction("BulkUpload");
           
     //   }

        // GET: app_cus_main/Create
        public ActionResult CreateImport()
        {
            //ViewBag.alert = "";
            //ViewBag.gender = new SelectList(db.app_gender, "id", "sex");
            //ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name");
            //ViewBag.citizenship = new SelectList(db.app_countries, "id", "name");
            ////ViewBag.kin_type = new SelectList(db.app_kin_type, "id", "kin_type_name");

            //ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat");
            //ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name");
            //ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number");
            //ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name");
            //ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code");
            //ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name");
            //ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code");
            //ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name");
            //ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateImport_([Bind(Include = "id,citizenship,home_type_code,age_cat_type_code,cus_type_code,title,firstname,lastname,middlename,dob,gender,security_code,occupation_code,img_url,sign_img_url,marital_status,child_num,cus_since,cus_doc_code,credit_limit,kin_type_code,created_by,modified_by,deleted_by,created_date,modified_date,deleted_date,rel_off_code,bran_code")]
                                                      app_cus_main app_cus_main
                                                    , app_cus_other_info app_cus_other_info
                                                    , app_cus_contact app_cus_contact
                                                    , app_gender app_gender
                                                    , app_kin_details app_kin_details

                                                     )
        {
            ViewBag.alert = "";

            var ck = _repository.CheckCustomer(app_cus_main.gender, app_cus_main.firstname, app_cus_main.lastname, app_cus_main.middlename, app_cus_main.dob, app_cus_other_info.verification_id, app_cus_contact.tele_number);


            if (ck)
            {
                ModelState.AddModelError("", "Customer Already exist");
            }



            if (ModelState.IsValid)
            {

                app_cus_main.created_by = _repository.GetLoginUser();
                app_cus_main.created_date = _repository.GetCurrentDateTime();
                app_cus_main.cus_since = _repository.GetCurrentDateTime();
                app_cus_main.img_url = "/image/photo";
                app_cus_main.status = "ini";
                app_cus_main.sign_img_url = "/image/signature";
                app_cus_main.app_cus_contact = app_cus_contact;
                app_cus_main.app_kin_details = app_kin_details;
                app_cus_main.app_cus_other_info = app_cus_other_info;

                app_cus_main.cus_code = _repository.GetImportCode(app_cus_main.id);
                db.app_cus_main.Add(app_cus_main);
                await db.SaveChangesAsync();
                ViewBag.alert = "saved";
                return RedirectToAction("Index");
            }
            else
            { ViewBag.alert = "error"; }

            var errors = ModelState.Values.SelectMany(v => v.Errors);
            ViewBag.citizenship = new SelectList(db.app_countries, "id", "name");
            ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name", app_cus_main.home_type_code);
            ViewBag.gender = new SelectList(db.app_gender, "id", "sex", app_cus_main.gender);
            ViewBag.age_cat_type_code = new SelectList(db.app_age_cate, "id", "name_of_cat", app_cus_main.age_cat_type_code);
            ViewBag.bran_code = new SelectList(db.app_branch, "id", "branch_name", app_cus_main.bran_code);
            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);
            ViewBag.cus_doc_code = new SelectList(db.app_cus_doc, "id", "cus_doc_name", app_cus_main.cus_doc_code);
            ViewBag.cus_other_code = new SelectList(db.app_cus_other_info, "id", "cus_other_code", app_cus_main.cus_other_code);
            ViewBag.cus_type_code = new SelectList(db.app_cus_type, "id", "type_name", app_cus_main.cus_type_code);
            ViewBag.kin_details_code = new SelectList(db.app_kin_details, "id", "kin_details_code", app_cus_main.kin_details_code);
            ViewBag.occupation_code = new SelectList(db.app_occupation, "id", "name", app_cus_main.occupation_code);
            ViewBag.rel_off_code = new SelectList(db.app_rel_office, "id", "full_name", app_cus_main.rel_off_code);
            ViewBag.home_type_code = new SelectList(db.app_home_type, "id", "type_name");

            return View(app_cus_main);
        }





    }
}