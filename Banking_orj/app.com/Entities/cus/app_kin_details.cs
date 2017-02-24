
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app.com.Data
{
    public class app_kin_details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity )]
        public int id { get; set; }
        public int kin_type_code { get; set; }
        public string kin_details_code { get; set; }
        public string full_name { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middle { get; set; }
        public string relationship { get; set; }
        public string tele_num_rel { get; set; }
        public string email { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string state { get; set; }

      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }

        //[ForeignKey("kin_type_code")]
        //[InverseProperty("app_kin_details")]
        //public virtual app_kin_type app_kin_type { get; set; }
    }
}