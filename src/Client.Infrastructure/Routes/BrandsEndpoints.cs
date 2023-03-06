namespace Inventory.Client.Infrastructure.Routes
{
    public static class BrandsEndpoints
    {
        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        public const string Export = "api/v1/brands/export";

        public const string GetAll = "api/v1/brands";
        public const string Delete = "api/v1/brands";
        public const string Save = "api/v1/brands";
        public const string GetCount = "api/v1/brands/count";
    }
}