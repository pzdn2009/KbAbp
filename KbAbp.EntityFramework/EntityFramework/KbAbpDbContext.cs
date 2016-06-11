using Abp.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KbAbp.EntityFramework
{
    public class KbAbpDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        public virtual IDbSet<Tasks.Task> Tasks { get; set; }
        public virtual IDbSet<Projects.Project> Projects { get; set; }
        public virtual IDbSet<Kbs.KbCategory> KbCategorys { get; set; }
        public virtual IDbSet<Kbs.KbCategoryItem> KbCategoryItems { get; set; }
        public virtual IDbSet<Kbs.KbQueue> KbQueues { get; set; }
        public virtual IDbSet<Kbs.Tag> Tags { get; set; }
        public virtual IDbSet<Kbs.KnowledgeCategory> KnowledgeCategories { get; set; }
        public virtual IDbSet<Kbs.Knowledge> Knowledges { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public KbAbpDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in KbAbpDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of KbAbpDbContext since ABP automatically handles it.
         */
        public KbAbpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
