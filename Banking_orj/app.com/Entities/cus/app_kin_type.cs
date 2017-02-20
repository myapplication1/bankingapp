﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.com.Data
{
    public class app_kin_type
    {
        [Key]
        public int id { get; set; }
        public int kin_type_code { get; set; }
        public string kin_type_name { get; set; }

   //     [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_kin_details> app_kin_details { get; set; }
    }
}