using System.Reflection;
using Abp.Modules;

namespace KbAbp
{
    public class KbAbpCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
