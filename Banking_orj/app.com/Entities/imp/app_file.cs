using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app.com.Data
{
    public class app_file
    {
        
  
        public HttpPostedFileBase File { get; set; }
       // public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}