using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace csumathboy.MomokoBlog.Data;

/* This is used if database provider does't define
 * IMomokoBlogDbSchemaMigrator implementation.
 */
public class NullMomokoBlogDbSchemaMigrator : IMomokoBlogDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
