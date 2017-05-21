
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.com.Validators;

namespace app.com.Data
{
    public class app_cus_main_mv
    {
        public int id { get; set; }
        [Required(ErrorMessage = "You must provide a Customer Type")]
        public int cus_type_code { get; set; }
        [Required(ErrorMessage = "You must provide a Customer Type")]
        public string cus_type_name { get; set; }
        [Required(ErrorMessage = "You must provide a Branch")]
        public int bran_code { get; set; }
        [Required(ErrorMessage = "You must provide a Customer ID")]
        public string cus_code { get; set; }
        [Required(ErrorMessage = "You must select a Relation Officer")]
        public int? rel_off_code { get; set; }
        [Required(ErrorMessage = "You must provide a Relation officer first name")]
        public string r_firstname { get; set; }
        public string r_middlename { get; set; }
        [Required(ErrorMessage = "You must provide a a Relation officer last name")]
        public string r_lastname { get; set; }
        public string r_full_name
        {
            get
            {
                return c_title + " " + c_firstname + " " + c_middlename + " " + c_lastname;
            }
        }
        public string c_title { get; set; }
        [Required(ErrorMessage = "You must provide a first name")]
        public string c_firstname { get; set; }
        public string c_middlename { get; set; }
        [Required(ErrorMessage = "You must provide a last name name")]
        public string c_lastname { get; set; }
        public string c_full_name
        {
            get
            {
                return c_title + " " + c_firstname + " " + c_middlename + " " + c_lastname;
            }
        }
        [Required(ErrorMessage = "You must provide a Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [AgeRange(18, 120, ErrorMessage = "Date of birth - Your age must be between {1}-{2}")]
        public Nullable<System.DateTime> dob { get; set; }
        public Nullable<int> age_cat_type_code { get; set; }
        public string img_url { get; set; }
        public string sign_img_url { get; set; }
        [Required(ErrorMessage = "You must select a gender")]
        public int? gender { get; set; }
        public Nullable<int> occupation_code { get; set; }
        public string marital_status { get; set; }
        public Nullable<int> child_num { get; set; }
        public Nullable<int> home_type_code { get; set; }
        [Display(Name = "Citizenship required")]
        public int citizenship { get; set; }

        [Required(ErrorMessage = "Customer since - Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> cus_since { get; set; }

        [Required(ErrorMessage = "You must provide a Telephone Number")]
        public string tele_number { get; set; }
        public string tele_number2 { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage = "You must provide a valid address")]
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string brief_location { get; set; }
        [Required(ErrorMessage = "Verification code required")]
        public string verification_id { get; set; }
        public string ssn { get; set; }
        public string tin_number { get; set; }
        [Required(ErrorMessage = "Security group required")]
        public string security_group { get; set; }
        public string status { get; set; }

    }
}