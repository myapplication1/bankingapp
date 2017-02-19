using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using app.com.Validators;

namespace app.com.Models
{
  public class EditCusModel
  {
        public int Id { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string age_cat_type_code { get; set; }
        public string bran_code { get; set; }
        public string brief_location { get; set; }
        public int child_num { get; set; }
        public string city { get; set; }
        public int? contact_code { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public decimal credit_limit { get; set; }
        public int? cus_code { get; set; }
        public string cus_doc_code { get; set; }
        public string cus_other_code { get; set; }
        public string cus_type_code { get; set; }
        public string deleted_by { get; set; }
        public DateTime deleted_date { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string firstname { get; set; }
        public string gender { get; set; }
        public string gps_cordinates { get; set; }
        public string home_type_code { get; set; }
        public string img_url { get; set; }
        public string kin_details_code { get; set; }
        public string lastname { get; set; }
        public string marital_status { get; set; }
        public string middlename { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public string occupation_code { get; set; }
        public string rel_off_code { get; set; }
        public string sign_img_url { get; set; }
        public string state { get; set; }
        public string tele_number { get; set; }
        public string title { get; set; }
        public string zip { get; set; }



    //    public int Id { get; set; }

    //[StringLength(2048, MinimumLength=5)]
    //public string Pitch { get; set; }

    //[DisplayName("Looking For")]
    //[StringLength(2048, MinimumLength = 15,
    //  ErrorMessage = "{0} should between {2} and {1} characters")]
    //public string LookingFor { get; set; }

    //[StringLength(4096, MinimumLength = 25)]
    //public string Introduction { get; set; }

    //[DisplayName("Birthday")]
    //[Required]
    //[AgeRange(18, 120, ErrorMessage="Your age must be between {1}-{2} in {0}")]
    //public DateTime Birthdate { get; set; }

    //[Required(ErrorMessage = "{0} must be specified.")]
    //public string Gender { get; set; }

    //public string MemberName { get; set; }

    //[DisplayName("Sexual Orientation")]
    //[Required]
    //public string Orientation { get; set; }
  }
}
