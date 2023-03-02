using System.Threading.Tasks;

namespace Inventory.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}