using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app.com.Data
{
    public class app_cus_doc
    {
        [Key]
        public int id { get; set; }
        public int cus_doc_code { get; set; }
        public string cus_doc_name { get; set; }
        public string cus_doc_url { get; set; }
        public int cus_doc_type_code { get; set; }
        public string createdby { get; set; }
        public string modifiedby { get; set; }
        public string deletedby { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public Nullable<System.DateTime> deleted_date { get; set; }


        [ForeignKey("cus_doc_code")]
        [InverseProperty("app_cus_doc")]
        public virtual app_doc_type app_doc_type { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}