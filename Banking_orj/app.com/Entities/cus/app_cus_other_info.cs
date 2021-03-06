﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.com.Data
{
    public class app_cus_other_info
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string cus_other_code { get; set; }
        [Required(ErrorMessage = "Verification ID Required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "verification id - Maximun Length 20")]
        public string verification_id { get; set; }
        //[Required]
        //[MaxLength(9)]
        //[MinLength(1)]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "ssn - must be numeric max 9 charaters")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "ssn - Maximun Length 20")]

        public string ssn { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "tax_number - Length between 1 to 30 Required")]
        public string tax_number { get; set; }

        //[Required(ErrorMessage = "Security Code Required")]
        //[StringLength(10, MinimumLength = 1, ErrorMessage = "Security group - Length between 1 to 10 Required")]
        public string security_group { get; set; }
        [StringLength(30, MinimumLength = 1, ErrorMessage = "tin number - Length between 1 to 20 Required")]

        public string tin_number { get; set; }


        
        // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}