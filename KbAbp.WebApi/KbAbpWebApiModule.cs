using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using KbAbp.Tasks;
using KbAbp.Projects;
using KbAbp.Kbs;

namespace KbAbp
{
    [DependsOn(typeof(AbpWebApiModule), typeof(KbAbpApplicationModule))]
    public class KbAbpWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //DynamicApiControllerBuilder.ForAll<IApplicationService>(typeof(KbAbpApplicationModule).Assembly, "app").Build();

            DynamicApiControllerBuilder.For<ITaskAppService>("app/task").Build();
            DynamicApiControllerBuilder.For<IProjectAppService>("app/project").Build();
            DynamicApiControllerBuilder.For<IKbCategoryAppService>("app/kbcategory").Build();
            DynamicApiControllerBuilder.For<IKbCategoryItemAppService>("app/kbcategoryitem").Build();
        }
    }
}
