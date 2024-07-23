using Microsoft.AspNetCore.Builder;
using csumathboy.MomokoBlog;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<MomokoBlogWebTestModule>();

public partial class Program
{
}
