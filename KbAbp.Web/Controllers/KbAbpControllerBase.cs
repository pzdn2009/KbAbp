using Abp.Web.Mvc.Controllers;

namespace KbAbp.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class KbAbpControllerBase : AbpController
    {
        protected KbAbpControllerBase()
        {
            LocalizationSourceName = KbAbpConsts.LocalizationSourceName;
        }
    }
}