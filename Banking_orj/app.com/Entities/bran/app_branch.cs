using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app.com.Data
{
    public class app_branch
    {
        [Key]
        public int id { get; set; }
        public int bran_code { get; set; }
        public string branch_name { get; set; }
        public Nullable<int> bran_type_code { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string assets { get; set; }

        [ForeignKey("bran_type_code")]
        [InverseProperty("app_branch")]
        public virtual app_bran_type app_bran_type { get; set; }
       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}