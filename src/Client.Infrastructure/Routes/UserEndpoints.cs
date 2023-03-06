namespace Inventory.Client.Infrastructure.Routes
{
    public static class UserEndpoints
    {
        public const string GetAll = "api/identity/user";

        public static string Get(string userId)
        {
            return $"api/identity/user/{userId}";
        }

        public static string GetUserRoles(string userId)
        {
            return $"api/identity/user/roles/{userId}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        public const string Export = "api/identity/user/export";
        public const string Register = "api/identity/user";
        public const string ToggleUserStatus = "api/identity/user/toggle-status";
        public const string ForgotPassword = "api/identity/user/forgot-password";
        public const string ResetPassword = "api/identity/user/reset-password";
    }
}