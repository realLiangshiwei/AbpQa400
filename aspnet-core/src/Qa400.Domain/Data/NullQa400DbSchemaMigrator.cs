using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa400.Data
{
    /* This is used if database provider does't define
     * IQa400DbSchemaMigrator implementation.
     */
    public class NullQa400DbSchemaMigrator : IQa400DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}