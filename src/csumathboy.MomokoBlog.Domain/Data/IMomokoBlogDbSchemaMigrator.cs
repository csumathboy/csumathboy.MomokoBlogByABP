using System.Threading.Tasks;

namespace csumathboy.MomokoBlog.Data;

public interface IMomokoBlogDbSchemaMigrator
{
    Task MigrateAsync();
}
