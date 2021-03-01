using System;
using System.Collections.Generic;
using System.Text;
using BrandChallenge.Localization;
using Volo.Abp.Application.Services;

namespace BrandChallenge
{
    /* Inherit your application services from this class.
     */
    public abstract class BrandChallengeAppService : ApplicationService
    {
        protected BrandChallengeAppService()
        {
            LocalizationResource = typeof(BrandChallengeResource);
        }
    }
}
