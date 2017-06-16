namespace CafePrintter.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DbConfig;
    using Migrations;

    [DbConfigurationType(typeof(CoreDbConfig))]
    public partial class CoreModel : DbContext
    {
        public CoreModel()
            : base("name=CoreModel")
        {
        }

        public virtual DbSet<device> device { get; set; }
        public virtual DbSet<setting> setting { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<device>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<device>()
                .Property(e => e.macAddress)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.key)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.createdUser)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.modifiedUser)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.deletedUser)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            //Database.SetInitializer<CoreModel>(null);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CoreModel, Configuration>());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("createdDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("createdDate").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    // Ignore the CreatedTime updates on Modified entities. 
                    entry.Property("createdDate").IsModified = false;
                }

                // Always set UpdatedTime. Assuming all entities having CreatedTime property
                // Also have UpdatedTime
                // entry.Property("UpdatedTime").CurrentValue = DateTime.Now;
                // I moved this part to another foreach loop
            }

            foreach (var entry in ChangeTracker.Entries().Where(
                e =>
                    e.Entity.GetType().GetProperty("modifiedDate") != null && (e.State == EntityState.Modified || e.State == EntityState.Added)))
            {
                entry.Property("modifiedDate").CurrentValue = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}
