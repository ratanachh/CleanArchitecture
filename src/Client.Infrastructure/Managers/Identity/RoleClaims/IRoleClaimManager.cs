using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Application.Requests.Identity;
using Inventory.Application.Responses.Identity;
using Inventory.Shared.Wrapper;

namespace Inventory.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}