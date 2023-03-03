using AutoMapper;
using Inventory.Infrastructure.Models.Identity;
using Inventory.Application.Responses.Identity;

namespace Inventory.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, InventoryUser>().ReverseMap();
            CreateMap<ChatUserResponse, InventoryUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}