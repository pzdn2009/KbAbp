using Abp.Web.Mvc.Views;

namespace KbAbp.Web.Views
{
    public abstract class KbAbpWebViewPageBase : KbAbpWebViewPageBase<dynamic>
    {

    }

    public abstract class KbAbpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected KbAbpWebViewPageBase()
        {
            LocalizationSourceName = KbAbpConsts.LocalizationSourceName;
        }
    }
}