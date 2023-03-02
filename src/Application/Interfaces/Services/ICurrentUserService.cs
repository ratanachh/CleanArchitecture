using Inventory.Application.Interfaces.Common;

namespace Inventory.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}