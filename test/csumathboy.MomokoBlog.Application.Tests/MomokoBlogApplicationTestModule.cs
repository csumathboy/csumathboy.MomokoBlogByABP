using Volo.Abp.Modularity;

namespace csumathboy.MomokoBlog;

[DependsOn(
    typeof(MomokoBlogApplicationModule),
    typeof(MomokoBlogDomainTestModule)
)]
public class MomokoBlogApplicationTestModule : AbpModule
{

}
