using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app.com.Data
{
    public class app_imp_history
    {
        [Key]
  
        public int id { get; set; }
        public string imp_type { get; set; }
        public string imp_name { get; set; }
        public DateTime imp_date { get; set; }
        public int imp_lines { get; set; }
        public int imp_erros { get; set; }
        public string importer { get; set; }
        public int progress { get; set; }
        public string status { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
       // public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}