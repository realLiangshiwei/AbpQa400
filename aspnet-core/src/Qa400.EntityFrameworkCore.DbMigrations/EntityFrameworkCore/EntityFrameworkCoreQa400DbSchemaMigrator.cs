using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qa400.Data;
using Volo.Abp.DependencyInjection;

namespace Qa400.EntityFrameworkCore
{
    public class EntityFrameworkCoreQa400DbSchemaMigrator
        : IQa400DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreQa400DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Qa400MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Qa400MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}