using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qa400.EntityFrameworkCore
{
    [DependsOn(
        typeof(Qa400EntityFrameworkCoreModule)
        )]
    public class Qa400EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<Qa400MigrationsDbContext>();
        }
    }
}
