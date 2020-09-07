using Volo.Abp.Modularity;

namespace Qa400
{
    [DependsOn(
        typeof(Qa400ApplicationModule),
        typeof(Qa400DomainTestModule)
        )]
    public class Qa400ApplicationTestModule : AbpModule
    {

    }
}