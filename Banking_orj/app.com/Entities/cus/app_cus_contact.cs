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


        
        [StringLength(15, MinimumLength = 9, ErrorMessage = "Maximun Length 15")]
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number -(777-777-7777)")]
        public string tele_number { get; set; }


        [StringLength(15, MinimumLength = 9, ErrorMessage = "Maximun Length 15")]
        [Required(ErrorMessage = "Your must provide a fax number")]
        [Display(Name = "Home fax")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number -(777-777-7777)")]

        public string fax { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        public string email { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]
        public string address1 { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]
        public string address2 { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]
        public string city { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]

        public string state { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]

        public string zip { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]

        public string brief_location { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]

        public string gps_cordinates { get; set; }
        public int? country_code { get; set; }




        [ForeignKey("country_code")]
        [InverseProperty("app_cus_contact")]
        public virtual app_countries app_countries { get; set; }

        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}