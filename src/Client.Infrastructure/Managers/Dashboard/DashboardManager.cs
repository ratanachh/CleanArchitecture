using Inventory.Client.Infrastructure.Extensions;
using Inventory.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;
using Inventory.Application.Features.Dashboards.Queries.GetData;

namespace Inventory.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}