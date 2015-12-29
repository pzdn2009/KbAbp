using Abp.Application.Services;

namespace KbAbp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class KbAbpAppServiceBase : ApplicationService
    {
        protected KbAbpAppServiceBase()
        {
            LocalizationSourceName = KbAbpConsts.LocalizationSourceName;
        }
    }
}