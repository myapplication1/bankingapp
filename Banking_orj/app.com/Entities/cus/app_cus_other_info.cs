
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

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]
        public string verification_id { get; set; }
        [Required]
        [MaxLength(9)]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = " must be numeric max 9 charaters")]
        public string ssn { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximun Length 30")]
        public string tax_number { get; set; }

        [StringLength(10, MinimumLength = 5, ErrorMessage = "Maximun Length 10")]
        public string security_group { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}