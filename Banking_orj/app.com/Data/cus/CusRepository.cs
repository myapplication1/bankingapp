using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using app.com.Entities;
using app.com.Models;
using AutoMapper.QueryableExtensions;

namespace app.com.Data
{
    public class CusRepository : ICusRepository 
    {
        private _DbContext _context;
        public CusRepository(_DbContext context)
        {
            _context = context;
        }

        public app_cus_main  GetCustomers(int code)
        {
           // var lowerUserName = code.ToLowerInvariant();

            return _context.app_cus_main 
                           .Include("app_cus_contact")
                           .Where(m => m.cus_code == code).FirstOrDefault();
        }

   
        
    }
}