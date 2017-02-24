using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.com.Data
{
    public class app_cus_contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int contact_code { get; set; }
        public string tele_number { get; set; }
        public string fax { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Not a valid email address")]
        public string email { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string brief_location { get; set; }
        public string gps_cordinates { get; set; }
        public int? country_code { get; set; }




        [ForeignKey("country_code")]
        [InverseProperty("app_cus_contact")]
        public virtual app_countries app_countries { get; set; }

        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}