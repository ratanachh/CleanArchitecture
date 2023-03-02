using Inventory.Application.Models.Chat;
using Inventory.Application.Responses.Identity;
using Inventory.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Application.Interfaces.Chat;

namespace Inventory.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}