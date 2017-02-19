
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.com.Data
{
    public class app_cus_main
    {
        [Key]
        public int id { get; set; }
        public int cus_type_code { get; set; }
       // [ForeignKey("app_branch")]
        public int bran_code { get; set; }
      //  [ForeignKey("app_rel_office")]
        public int rel_off_code { get; set; }
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public int age_cat_type_code { get; set; }
        public int gender { get; set; }
        public int occupation_code { get; set; }
        public int cus_code { get; set; }
        public string img_url { get; set; }
        public string sign_img_url { get; set; }
        public string marital_status { get; set; }
        public Nullable<int> child_num { get; set; }
        public int home_type_code { get; set; }
        public Nullable<System.DateTime> cus_since { get; set; }
        public int cus_other_code { get; set; }
        public int kin_details_code { get; set; }
        [ForeignKey("app_cus_contact")]
        public int? contact_code { get; set; }
        public int cus_doc_code { get; set; }
        public Nullable<decimal> credit_limit { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public string deleted_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public Nullable<System.DateTime> deleted_date { get; set; }
        //[Display(Name = "Full Name")]
        public string full_name
        {
            get
            {
                return firstname + " " + lastname;
            }
        }



        //public virtual app_age_cate app_age_cate { get; set; }
        //public virtual app_branch app_branch { get; set; }
        [ForeignKey("contact_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_cus_contact app_cus_contact { get; set; }
        //public virtual app_cus_doc app_cus_doc { get; set; }
        //public virtual app_cus_other_info app_cus_other_info { get; set; }
        //public virtual app_cus_type app_cus_type { get; set; }
        //public virtual app_gender app_gender { get; set; }
        //public virtual app_gender app_gender1 { get; set; }
        //public virtual app_home_type app_home_type { get; set; }
        //public virtual app_kin_details app_kin_details { get; set; }
        //public virtual app_occupation app_occupation { get; set; }
        //public virtual app_rel_office app_rel_office { get; set; }
    }
}