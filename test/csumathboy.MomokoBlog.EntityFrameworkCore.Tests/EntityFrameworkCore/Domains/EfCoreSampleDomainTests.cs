using csumathboy.MomokoBlog.Samples;
using Xunit;

namespace csumathboy.MomokoBlog.EntityFrameworkCore.Domains;

[Collection(MomokoBlogTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MomokoBlogEntityFrameworkCoreTestModule>
{

}
