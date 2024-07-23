using csumathboy.MomokoBlog.Samples;
using Xunit;

namespace csumathboy.MomokoBlog.EntityFrameworkCore.Applications;

[Collection(MomokoBlogTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MomokoBlogEntityFrameworkCoreTestModule>
{

}
