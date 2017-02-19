
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.com.Data
{
    public class app_doc_type
    {
        [Key]
        public int id { get; set; }
        public int doc_type_code { get; set; }
        public string name { get; set; }
        public string type { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_doc> app_cus_doc { get; set; }
    }
}