using AutoMapper;
using Inventory.Application.Interfaces.Chat;
using Inventory.Application.Models.Chat;
using Inventory.Infrastructure.Models.Identity;

namespace Inventory.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}