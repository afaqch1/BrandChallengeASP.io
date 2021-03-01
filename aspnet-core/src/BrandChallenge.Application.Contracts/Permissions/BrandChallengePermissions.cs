namespace BrandChallenge.Permissions
{
    public static class BrandChallengePermissions
    {
        public const string GroupName = "BrandChallenge";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static class Brands
        {
            public const string Default = GroupName + ".Brands";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        public static class Challenges
        {
            public const string Default = GroupName + ".Challenges";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        public static class Tricks
        {
            public const string Default = GroupName + ".Tricks";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }
}