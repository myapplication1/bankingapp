using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using app.com.Entities;
using app.com.Models;
using AutoMapper.QueryableExtensions;
using System.Web.Mvc;
using System.Globalization;
 using app.com.Data.impp;

namespace app.com.Data
{
    public class ImpRepository : IImpRepository1
    {
        private _DbContext _context;
        public ImpRepository(_DbContext context)
        {
            _context = context;
        }

        // get user customer obj by id
        public app_imp_history  GetImports(int? id)
        {
         
            return _context.app_imp_history
                           .Where(m => m.id == id && m.status =="ini").FirstOrDefault();
        }

        public IEnumerable<app_imp_history> GetAllImports(int number)
        {

            return _context.app_imp_history
                           
                           .Where(m => m.status  == "ini").ToList().Take(number);

        }

        //check fo customer duplicates
        public bool CheckCustomer(int gender, string firstname_, string lastname, string surname, DateTime dob, string vId, string tel)
        {
            var getReults = _context.app_cus_main
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

        public IEnumerable<app_imp_history> Imports()
        {

            return _context.app_imp_history
                     .ToList();
            //.Where(m => m.id == id).FirstOrDefault();
        }


        //get user logged in
        public string GetLoginUser()
        {          

            return "user_name";
        }

      
        //get current datetime 
        public DateTime  GetCurrentDateTime()
        {
            return DateTime.Today;
        }

        ////get all countries
        ////public IEnumerable<SelectListItem> GetCountries()
        //{
        //    RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);
        //    List<SelectListItem> countryNames = new List<SelectListItem>();

        //    //To get the Country Names from the CultureInfo installed in windows
        //    foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
        //    {
        //        country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
        //        countryNames.Add(new SelectListItem() { Text = country.DisplayName, Value = country.DisplayName });
        //    }

        //    //Assigning all Country names to IEnumerable
        //    IEnumerable<SelectListItem> nameAdded = countryNames.GroupBy(x => x.Text).Select(x => x.FirstOrDefault()).ToList<SelectListItem>().OrderBy(x => x.Text);
        //    return nameAdded;
        //}

        public string  GetImportCode(int id)
        {
            var prefix = "imp";
            // var prefix = "cus";
            // Create and display the value of two GUIDs.
            var code = prefix + id;
            return code;
          //  return g;
        }

        public string PrcessError()
        {
            return "oo";
        }

        public string AlertManage()
        {
            return "oo";
        }


        public string Commit()
        {
            return "oo";
        }


        public string Abort()
        {
            return "oo";
        }





    }
}