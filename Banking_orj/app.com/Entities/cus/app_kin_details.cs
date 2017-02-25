
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

       
        [Required(ErrorMessage = "Required")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string firstname { get; set; }
    
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string lastname { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string middle { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string relationship { get; set; }

       

        [StringLength(15, MinimumLength = 9, ErrorMessage = "Maximun Length 15")]
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number -(777-777-7777)")]
        public string tele_num_rel { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        public string email { get; set; }

       
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string address1 { get; set; }

     
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string address2 { get; set; }

        
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string zip { get; set; }

    
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string city { get; set; }

    
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Maximun Length 30")]
        public string state { get; set; }
        public string full_name
        {
            get
            {
                return firstname + " " + lastname;
            }
        }
        //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }

        //[ForeignKey("kin_type_code")]
        //[InverseProperty("app_kin_details")]
        //public virtual app_kin_type app_kin_type { get; set; }
    }
}