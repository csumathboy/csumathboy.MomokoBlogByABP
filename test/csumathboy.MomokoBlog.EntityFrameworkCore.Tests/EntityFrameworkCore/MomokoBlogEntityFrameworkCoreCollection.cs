using Xunit;

namespace csumathboy.MomokoBlog.EntityFrameworkCore;

[CollectionDefinition(MomokoBlogTestConsts.CollectionDefinitionName)]
public class MomokoBlogEntityFrameworkCoreCollection : ICollectionFixture<MomokoBlogEntityFrameworkCoreFixture>
{

}
