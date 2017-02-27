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


        
        [StringLength(15, MinimumLength = 9, ErrorMessage = "phone - Length between 9 to 15 Required")]
        [Required(ErrorMessage = "You must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number -(xxx-xxx-xxxx)")]
        public string tele_number { get; set; }


        [StringLength(15, MinimumLength = 9, ErrorMessage = "fax - Lenght between 9 to 15 Required")]
        [Required(ErrorMessage = "You must provide a fax number")]
        [Display(Name = "Home fax")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number -(xxx-xxx-xxxx)")]

        public string fax { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        public string email { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "address - Length between 1 to 30 Required")]
        public string address1 { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "address 2 - Length between 1 to 30 Required")]
        public string address2 { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "city - Length between 1 to 30 Required")]
        public string city { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "state - Length between 1 to 30 Required")]

        public string state { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "aip - Length between 1 to 30 Required")]

        public string zip { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "brief location - Length between 5 to 30 Required")]

        public string brief_location { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "gps cordinates - Length between 5 to 30 Required")]

        public string gps_cordinates { get; set; }
        public int? country_code { get; set; }




        [ForeignKey("country_code")]
        [InverseProperty("app_cus_contact")]
        public virtual app_countries app_countries { get; set; }

        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}