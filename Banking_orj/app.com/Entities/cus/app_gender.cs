
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.com.Data
{
    public class app_gender
    {
        [Key]
        public int id { get; set; }
        public string gender_code { get; set; }
        public string sex { get; set; }

        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}