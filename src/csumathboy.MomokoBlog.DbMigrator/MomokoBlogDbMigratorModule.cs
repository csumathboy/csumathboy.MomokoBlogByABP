using csumathboy.MomokoBlog.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace csumathboy.MomokoBlog.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MomokoBlogEntityFrameworkCoreModule),
    typeof(MomokoBlogApplicationContractsModule)
    )]
public class MomokoBlogDbMigratorModule : AbpModule
{
}
