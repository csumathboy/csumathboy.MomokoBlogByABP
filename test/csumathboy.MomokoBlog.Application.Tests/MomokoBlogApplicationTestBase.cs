using Volo.Abp.Modularity;

namespace csumathboy.MomokoBlog;

public abstract class MomokoBlogApplicationTestBase<TStartupModule> : MomokoBlogTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
