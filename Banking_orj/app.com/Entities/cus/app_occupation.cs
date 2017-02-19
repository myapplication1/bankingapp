
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app.com.Data
{
    public class app_occupation
    {
        [Key]
        public int id { get; set; }
        public string occ_code { get; set; }
        public string name { get; set; }

     //   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}