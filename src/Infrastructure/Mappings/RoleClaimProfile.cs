using AutoMapper;
using Inventory.Application.Requests.Identity;
using Inventory.Application.Responses.Identity;
using Inventory.Infrastructure.Models.Identity;

namespace Inventory.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, InventoryRoleClaim>()
                .ForMember(nameof(InventoryRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(InventoryRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, InventoryRoleClaim>()
                .ForMember(nameof(InventoryRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(InventoryRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}