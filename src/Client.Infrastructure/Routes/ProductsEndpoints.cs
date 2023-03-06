using System.Linq;

namespace Inventory.Client.Infrastructure.Routes
{
    public static class ProductsEndpoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string searchString, string[] orderBy)
        {
            var url = $"api/v1/products?pageNumber={pageNumber}&pageSize={pageSize}&searchString={searchString}&orderBy=";
            if (orderBy?.Any() != true) return url;
            url = orderBy.Aggregate(url, (current, orderByPart) => current + $"{orderByPart},");
            url = url[..^1]; // loose training ,
            return url;
        }

        public const string GetCount = "api/v1/products/count";

        public static string GetProductImage(int productId)
        {
            return $"api/v1/products/image/{productId}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        public const string Save = "api/v1/products";
        public const string Delete = "api/v1/products";
        public const string Export = "api/v1/products/export";
        public const string ChangePassword = "api/identity/account/changepassword";
        public const string UpdateProfile = "api/identity/account/updateprofile";
    }
}