using Inventory.Application.Interfaces.Common;
using Inventory.Application.Requests.Identity;
using Inventory.Application.Responses.Identity;
using Inventory.Shared.Wrapper;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}