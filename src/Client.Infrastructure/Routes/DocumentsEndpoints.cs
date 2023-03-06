namespace Inventory.Client.Infrastructure.Routes
{
    public static class DocumentsEndpoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string searchString)
        {
            return $"api/documents?pageNumber={pageNumber}&pageSize={pageSize}&searchString={searchString}";
        }

        public static string GetById(int documentId)
        {
            return $"api/documents/{documentId}";
        }

        public const string Save = "api/documents";
        public const string Delete = "api/documents";
    }
}