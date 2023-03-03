using AutoMapper;
using Inventory.Infrastructure.Models.Identity;
using Inventory.Application.Responses.Identity;

namespace Inventory.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, InventoryRole>().ReverseMap();
        }
    }
}