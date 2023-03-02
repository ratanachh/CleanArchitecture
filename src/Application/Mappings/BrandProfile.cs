using AutoMapper;
using Inventory.Application.Features.Brands.Commands.AddEdit;
using Inventory.Application.Features.Brands.Queries.GetAll;
using Inventory.Application.Features.Brands.Queries.GetById;
using Inventory.Domain.Entities.Catalog;

namespace Inventory.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}