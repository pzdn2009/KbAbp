using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using KbAbp.EntityFramework;

namespace KbAbp
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(KbAbpCoreModule))]
    public class KbAbpDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<KbAbpDbContext>(null);
        }
    }
}
