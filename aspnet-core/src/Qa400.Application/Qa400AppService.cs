using System;
using System.Collections.Generic;
using System.Text;
using Qa400.Localization;
using Volo.Abp.Application.Services;

namespace Qa400
{
    /* Inherit your application services from this class.
     */
    public abstract class Qa400AppService : ApplicationService
    {
        protected Qa400AppService()
        {
            LocalizationResource = typeof(Qa400Resource);
        }
    }
}
