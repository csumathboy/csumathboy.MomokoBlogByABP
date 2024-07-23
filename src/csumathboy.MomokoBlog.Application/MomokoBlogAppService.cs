using System;
using System.Collections.Generic;
using System.Text;
using csumathboy.MomokoBlog.Localization;
using Volo.Abp.Application.Services;

namespace csumathboy.MomokoBlog;

/* Inherit your application services from this class.
 */
public abstract class MomokoBlogAppService : ApplicationService
{
    protected MomokoBlogAppService()
    {
        LocalizationResource = typeof(MomokoBlogResource);
    }
}
