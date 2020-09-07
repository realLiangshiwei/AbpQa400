using Qa400.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa400
{
    [DependsOn(
        typeof(Qa400EntityFrameworkCoreTestModule)
        )]
    public class Qa400DomainTestModule : AbpModule
    {

    }
}