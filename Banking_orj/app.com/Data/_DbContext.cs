using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using app.com.Models;
//using app.com.Models;

namespace app.com.Data
{
  public class _DbContext : DbContext
  {
    public _DbContext()
      : base("Entities")
    {
      this.Configuration.LazyLoadingEnabled = false;
      this.Configuration.ProxyCreationEnabled = false;
      //Database.SetInitializer<_DbContext>(new _Initializer());
    }

   
        public DbSet<app_cus_main> app_cus_main { get; set; }
        public DbSet<app_cus_contact> app_cus_contact { get; set; }
        public virtual DbSet<app_age_cate> app_age_cate { get; set; }
        public virtual DbSet<app_bran_type> app_bran_type { get; set; }
        public virtual DbSet<app_branch> app_branch { get; set; }
        //public virtual DbSet<app_cus_contact> app_cus_contact { get; set; }
        public virtual DbSet<app_cus_doc> app_cus_doc { get; set; }
        //public virtual DbSet<app_cus_main> app_cus_main { get; set; }
        public virtual DbSet<app_cus_other_info> app_cus_other_info { get; set; }
        public virtual DbSet<app_cus_type> app_cus_type { get; set; }
        public virtual DbSet<app_doc_type> app_doc_type { get; set; }
        public virtual DbSet<app_gender> app_gender { get; set; }
        public virtual DbSet<app_home_type> app_home_type { get; set; }
        public virtual DbSet<app_kin_details> app_kin_details { get; set; }
        public virtual DbSet<app_kin_type> app_kin_type { get; set; }
        public virtual DbSet<app_occupation> app_occupation { get; set; }
        public virtual DbSet<app_rel_office> app_rel_office { get; set; }
        public virtual DbSet<app_countries> app_countries { get; set; }

        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //  base.OnModelCreating(modelBuilder);

        //  modelBuilder.Entity<Member>()
        //    .HasOptional<Profile>(m => m.Profile)
        //    .WithRequired(m => m.Member)
        //    .Map(p => p.MapKey("MemberId"));
        //}

        public System.Data.Entity.DbSet<app.com.Models.EditCusModel> EditCusModels { get; set; }
    }
}