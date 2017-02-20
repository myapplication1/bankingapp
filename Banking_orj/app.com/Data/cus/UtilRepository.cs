//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
////using app.com.Entities;
//using app.com.Models;
//using AutoMapper.QueryableExtensions;
//using System.Web.Mvc;
//using System.Globalization;

//namespace app.com.Data
//{
//    public class CusRepository : ICusRepository
//    {
//        private _DbContext _context;
//        public CusRepository(_DbContext context)
//        {
//            _context = context;
//        }

//        // get user customer obj by id
//        public app_cus_main  GetCustomers(int? id)
//        {
         
//            //return _context.app_cus_main 
//            //               .Include("app_cus_contact")
//            //               .Include("app_cus_other_info")
//            //               .Where(m => m.id == id).FirstOrDefault();
//        }


//        ////get user logged in
//        //public string GetLoginUser()
//        //{          

//        //    return "user_name";
//        //}

//        ////get current datetime 
//        //public DateTime  GetCurrentDateTime()
//        //{
//        //    return DateTime.Today;
//        //}

//        ////get all countries
//        //public IEnumerable<SelectListItem> GetCountries()
//        //{
//        //    RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);
//        //    List<SelectListItem> countryNames = new List<SelectListItem>();

//        //    //To get the Country Names from the CultureInfo installed in windows
//        //    foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
//        //    {
//        //        country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
//        //        countryNames.Add(new SelectListItem() { Text = country.DisplayName, Value = country.DisplayName });
//        //    }

//        //    //Assigning all Country names to IEnumerable
//        //    IEnumerable<SelectListItem> nameAdded = countryNames.GroupBy(x => x.Text).Select(x => x.FirstOrDefault()).ToList<SelectListItem>().OrderBy(x => x.Text);
//        //    return nameAdded;
//        //}



//    }
//}