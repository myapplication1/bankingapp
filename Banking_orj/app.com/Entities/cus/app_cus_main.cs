
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.com.Validators;

namespace app.com.Data
{
    public class app_cus_main
    {
        //[Key]
        //public int id { get; set; }
        //public int? cus_type_code { get; set; }
        //public int bran_code { get; set; }
        //public Nullable<int> rel_off_code { get; set; }
        //public string title { get; set; }
        //public string firstname { get; set; }
        //public string lastname { get; set; }
        //public string middlename { get; set; }
        //public Nullable<System.DateTime> dob { get; set; }
        //public Nullable<int> age_cat_type_code { get; set; }
        //public Nullable<int> gender { get; set; }
        //public Nullable<int> occupation_code { get; set; }
        //public int cus_code
        //{
        //    get
        //    {
        //        return id;
        //    }
        //}
        //public string img_url { get; set; }
        //public string sign_img_url { get; set; }
        //public string marital_status { get; set; }
        //public Nullable<int> child_num { get; set; }
        //public string home_type_code { get; set; }
        //public Nullable<System.DateTime> cus_since { get; set; }
        //public Nullable<int> cus_other_code { get; set; }
        //public Nullable<int> kin_details_code { get; set; }
        //public Nullable<int> contact_code { get; set; }
        //public Nullable<int> cus_doc_code { get; set; }
        //public Nullable<decimal> credit_limit { get; set; }
        //public string created_by { get; set; }
        //public string modified_by { get; set; }
        //public string deleted_by { get; set; }
        //public Nullable<System.DateTime> created_date { get; set; }
        //public Nullable<System.DateTime> modified_date { get; set; }
        //public Nullable<System.DateTime> deleted_date { get; set; }

        //public string full_name
        //{
        //    get
        //    {
        //        return firstname + " " + lastname;
        //    }
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "Type Required")]
        public int cus_type_code { get; set; }

        [Required(ErrorMessage = "Branch Required")]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "Maximun Length 30")]
        public int bran_code { get; set; }

        [Required(ErrorMessage = "Relation Office Required")]
        public Nullable<int> rel_off_code { get; set; }

        public string title { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "first name Between 1 to Length 50 Require")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        //[Required(ErrorMessage = "Required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "last name - Between 1 to Length 50 Require")]

        public string lastname { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Middle name - Between 1 to Length 50 Require")]

        public string middlename { get; set; }

        [Required(ErrorMessage = "Date of Birth Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [AgeRange(18, 120, ErrorMessage = "Date of birth - Your age must be between {1}-{2}")]
        public Nullable<System.DateTime> dob { get; set; }

        //[Required(ErrorMessage = "Required")]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "Maximun Length 30")]
        public Nullable<int> age_cat_type_code { get; set; }

        [Required(ErrorMessage = "Gender Required")]
        public Nullable<int> gender { get; set; }

        //[Required(ErrorMessage = "Occupation Required")]
        public Nullable<int> occupation_code { get; set; }

       // [Required(ErrorMessage = "Required")]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "Maximun Length 30")]
        public string  cus_code { get; set; }

        public string img_url { get; set; }
        public string sign_img_url { get; set; }

     //   [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string marital_status { get; set; }

        [Range(0, 15, ErrorMessage = "Children - expected numbers between 0 .. 100")]
        public Nullable<int> child_num { get; set; }
      
        [Required(ErrorMessage = "Customer since - Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy/MM/dd}")]
        public Nullable<System.DateTime> cus_since { get; set; }
        public Nullable<int> cus_other_code { get; set; }
        public int kin_details_code { get; set; }
        public Nullable<int> contact_code { get; set; }
        public Nullable<int> cus_doc_code { get; set; }
        public Nullable<int> home_type_code { get; set; }
        [Range(1, (double)decimal.MaxValue, ErrorMessage = "credit limit - value should be between{1} and {2}.")]
        public Nullable<decimal> credit_limit { get; set; }
        //[Required]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public string deleted_by { get; set; }
        public string status { get; set; }

        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public Nullable<System.DateTime> deleted_date { get; set; }
        public string full_name
        {
            get
            {
                return firstname + " " + lastname;
            }
        }

        [Display(Name = "Citizenship required")]
        public int citizenship { get; set; }



        [ForeignKey("citizenship")]
        [InverseProperty("app_cus_main")]
        public virtual app_countries app_countries { get; set; }



        [ForeignKey("age_cat_type_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_age_cate app_age_cate { get; set; }

        [ForeignKey("bran_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_branch app_branch { get; set; }

        [ForeignKey("contact_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_cus_contact app_cus_contact { get; set; }

        [ForeignKey("cus_doc_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_cus_doc app_cus_doc { get; set; }

        [ForeignKey("cus_other_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_cus_other_info app_cus_other_info { get; set; }

        [ForeignKey("cus_type_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_cus_type app_cus_type { get; set; }

        [ForeignKey("kin_details_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_kin_details app_kin_details { get; set; }

        [ForeignKey("occupation_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_occupation app_occupation { get; set; }

        [ForeignKey("home_type_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_home_type app_home_type { get; set; }

        [ForeignKey("rel_off_code")]
        [InverseProperty("app_cus_main")]
        public virtual app_rel_office app_rel_office { get; set; }


    }
}