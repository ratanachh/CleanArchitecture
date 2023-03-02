using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Application.Interfaces.Common;
using Inventory.Application.Requests.Identity;
using Inventory.Application.Responses.Identity;
using Inventory.Shared.Wrapper;

namespace Inventory.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}