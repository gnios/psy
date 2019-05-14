using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Psy.Controllers
{
    public abstract class PsyControllerBase: AbpController
    {
        protected PsyControllerBase()
        {
            LocalizationSourceName = PsyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
