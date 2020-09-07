using Qa400.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qa400.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Qa400EntityFrameworkCoreDbMigrationsModule),
        typeof(Qa400ApplicationContractsModule)
        )]
    public class Qa400DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
