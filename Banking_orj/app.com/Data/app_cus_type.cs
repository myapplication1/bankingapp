//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app.com.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class app_cus_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public app_cus_type()
        {
            this.app_cus_main = new HashSet<app_cus_main>();
        }
    
        public int id { get; set; }
        public string cus_type_code { get; set; }
        public string type_name { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_cus_main> app_cus_main { get; set; }
    }
}
