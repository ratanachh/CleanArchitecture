using AutoMapper;
using Inventory.Application.Features.Documents.Commands.AddEdit;
using Inventory.Application.Features.Documents.Queries.GetById;
using Inventory.Domain.Entities.Misc;

namespace Inventory.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}