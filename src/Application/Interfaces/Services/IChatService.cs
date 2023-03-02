using Inventory.Application.Responses.Identity;
using Inventory.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Application.Interfaces.Chat;
using Inventory.Application.Models.Chat;

namespace Inventory.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}