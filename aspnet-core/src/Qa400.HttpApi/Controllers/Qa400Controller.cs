using Qa400.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa400.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Qa400Controller : AbpController
    {
        protected Qa400Controller()
        {
            LocalizationResource = typeof(Qa400Resource);
        }
    }
}