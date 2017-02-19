
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app.com.Data
{
    public class app_cus_type
    {
        [Key]
        public int id { get; set; }
        public string cus_type_code { get; set; }
        public string type_name { get; set; }
        public string status { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}