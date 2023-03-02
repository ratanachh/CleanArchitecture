using Inventory.Application.Features.Products.Commands.AddEdit;
using Inventory.Application.Features.Products.Queries.GetAllPaged;
using Inventory.Application.Requests.Catalog;
using Inventory.Shared.Wrapper;
using System.Threading.Tasks;

namespace Inventory.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}