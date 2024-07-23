using csumathboy.MomokoBlog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace csumathboy.MomokoBlog.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MomokoBlogPageModel : AbpPageModel
{
    protected MomokoBlogPageModel()
    {
        LocalizationResourceType = typeof(MomokoBlogResource);
    }
}
