using BrandChallenge.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BrandChallenge.Permissions
{
    public class BrandChallengePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var brandchallengeGroup = context.AddGroup(BrandChallengePermissions.GroupName, L("Permission:BrandChallenge"));

            var brandsPermission = brandchallengeGroup.AddPermission(BrandChallengePermissions.Brands.Default, L("Permission:Brands"));
            brandsPermission.AddChild(BrandChallengePermissions.Brands.Create, L("Permission:Brands.Create"));
            brandsPermission.AddChild(BrandChallengePermissions.Brands.Edit, L("Permission:Brands.Edit"));
            brandsPermission.AddChild(BrandChallengePermissions.Brands.Delete, L("Permission:Brands.Delete"));

            var challengesPermission = brandchallengeGroup.AddPermission(BrandChallengePermissions.Challenges.Default, L("Permission:Challenges"));
            challengesPermission.AddChild(BrandChallengePermissions.Challenges.Create, L("Permission:Challenges.Create"));
            challengesPermission.AddChild(BrandChallengePermissions.Challenges.Edit, L("Permission:Challenges.Edit"));
            challengesPermission.AddChild(BrandChallengePermissions.Challenges.Delete, L("Permission:Challenges.Delete"));

            var tricksPermission = brandchallengeGroup.AddPermission(BrandChallengePermissions.Tricks.Default, L("Permission:Tricks"));
            tricksPermission.AddChild(BrandChallengePermissions.Tricks.Create, L("Permission:Tricks.Create"));
            tricksPermission.AddChild(BrandChallengePermissions.Tricks.Edit, L("Permission:Tricks.Edit"));
            tricksPermission.AddChild(BrandChallengePermissions.Tricks.Delete, L("Permission:Tricks.Delete"));
        }


        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BrandChallengeResource>(name);
        }
    }
}
