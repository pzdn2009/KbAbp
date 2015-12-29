using System.Reflection;
using Abp.Modules;

namespace KbAbp
{
    [DependsOn(typeof(KbAbpCoreModule))]
    public class KbAbpApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
