using Volo.Abp.Modularity;

namespace csumathboy.MomokoBlog;

[DependsOn(
    typeof(MomokoBlogDomainModule),
    typeof(MomokoBlogTestBaseModule)
)]
public class MomokoBlogDomainTestModule : AbpModule
{

}
