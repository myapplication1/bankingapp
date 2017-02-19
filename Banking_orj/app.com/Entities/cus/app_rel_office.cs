using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app.com.Data
{
    public class app_rel_office
    {
        [Key]
        public int id { get; set; }
        public string rel_code { get; set; }
        public string full_name { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string status { get; set; }
        public string bran_code { get; set; }

      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}