using AutoMapper;
using Inventory.Application.Features.Products.Commands.AddEdit;
using Inventory.Domain.Entities.Catalog;

namespace Inventory.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}