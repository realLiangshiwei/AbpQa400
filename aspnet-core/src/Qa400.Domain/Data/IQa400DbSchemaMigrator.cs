using System.Threading.Tasks;

namespace Qa400.Data
{
    public interface IQa400DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
