using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qa400.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(Qa400HttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class Qa400ConsoleApiClientModule : AbpModule
    {
        
    }
}
