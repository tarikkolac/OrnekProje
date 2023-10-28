using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OrnekProje.Controllers
{
    public abstract class OrnekProjeControllerBase: AbpController
    {
        protected OrnekProjeControllerBase()
        {
            LocalizationSourceName = OrnekProjeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
