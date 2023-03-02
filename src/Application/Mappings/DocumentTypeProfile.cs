using AutoMapper;
using Inventory.Application.Features.DocumentTypes.Commands.AddEdit;
using Inventory.Application.Features.DocumentTypes.Queries.GetAll;
using Inventory.Application.Features.DocumentTypes.Queries.GetById;
using Inventory.Domain.Entities.Misc;

namespace Inventory.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}