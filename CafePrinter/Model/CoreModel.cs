//namespace CafePrintter.Model
//{
//    using System;
//    using System.Data.Entity;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Linq;
//    using DbConfig;
//    using Migrations;
//    using System.Data.Entity.Infrastructure;
//    using System.Data.Entity.Core.Objects;
//    using Base;

//    [DbConfigurationType(typeof(CoreDbConfig))]
//    public partial class CoreModel : DbContext
//    {
//        public CoreModel()
//            : base("name=CoreModel")
//        {
//        }

//        public virtual DbSet<device> device { get; set; }
//        public virtual DbSet<sys_setting> sys_setting { get; set; }
//        public virtual DbSet<sys_user> sys_user { get; set; }
//        public virtual DbSet<control_type> control_type { get; set; }
//        public virtual DbSet<control> control { get; set; }
//        public virtual DbSet<control_type_use_control> control_type_use_control { get; set; }
//        public virtual DbSet<data_type> data_type { get; set; }
//        public virtual DbSet<meta> meta { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<sys_setting>().Property(p => p.rowVersion).IsConcurrencyToken();



//            //Database.SetInitializer<CoreModel>(null);
//            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CoreModel, Configuration>());
//        }

//        public override int SaveChanges()
//        {
//            var objectContextAdapter = this as IObjectContextAdapter;
//            if (objectContextAdapter != null)
//            {
//                objectContextAdapter.ObjectContext.DetectChanges();
//                foreach (ObjectStateEntry entry in objectContextAdapter.ObjectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Modified))
//                {
//                    var v = entry.Entity as IVersionedRow;
//                    if (v != null)
//                        v.rowVersion++;
//                }
//            }



//            foreach (var entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("createdDate") != null))
//            {
//                if (entry.State == EntityState.Added)
//                {
//                    entry.Property("createdDate").CurrentValue = DateTime.Now;
//                }
//                else if (entry.State == EntityState.Modified)
//                {
//                    // Ignore the CreatedTime updates on Modified entities. 
//                    entry.Property("createdDate").IsModified = false;
//                }

//                // Always set UpdatedTime. Assuming all entities having CreatedTime property
//                // Also have UpdatedTime
//                // entry.Property("UpdatedTime").CurrentValue = DateTime.Now;
//                // I moved this part to another foreach loop
//            }

//            foreach (var entry in ChangeTracker.Entries().Where(
//                e =>
//                    e.Entity.GetType().GetProperty("modifiedDate") != null && (e.State == EntityState.Modified)))
//            {
//                entry.Property("modifiedDate").CurrentValue = DateTime.Now;
//            }

//            return base.SaveChanges();
//        }
//    }
//}
