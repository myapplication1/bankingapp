using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app.com.Data;
using app.com.Models;
using app.com.Extensions;

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

        public ActionResult EditCustomer(int code)
        {
            app_cus_main app_cus_main = _repository.GetCustomers(code);

            ViewBag.contact_code = new SelectList(db.app_cus_contact, "id", "tele_number", app_cus_main.contact_code);

            return View(app_cus_main );
        }

        

    }
}