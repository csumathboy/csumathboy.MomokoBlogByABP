using csumathboy.MomokoBlog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace csumathboy.MomokoBlog.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MomokoBlogController : AbpControllerBase
{
    protected MomokoBlogController()
    {
        LocalizationResource = typeof(MomokoBlogResource);
    }
}
