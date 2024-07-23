using Volo.Abp.Modularity;

namespace csumathboy.MomokoBlog;

/* Inherit from this class for your domain layer tests. */
public abstract class MomokoBlogDomainTestBase<TStartupModule> : MomokoBlogTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
