using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.com.Data
{
    public class app_cus_contact
    {
        [Key]
        public int id { get; set; }
        public int? contact_code { get; set; }
        public string tele_number { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string brief_location { get; set; }
        public string gps_cordinates { get; set; }

        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}