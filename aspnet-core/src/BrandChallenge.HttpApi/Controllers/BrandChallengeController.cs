using BrandChallenge.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BrandChallenge.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BrandChallengeController : AbpController
    {
        protected BrandChallengeController()
        {
            LocalizationResource = typeof(BrandChallengeResource);
        }
    }
}