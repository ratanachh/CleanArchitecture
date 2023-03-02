using Inventory.Shared.Wrapper;
using System.Threading.Tasks;
using Inventory.Application.Features.Dashboards.Queries.GetData;

namespace Inventory.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}