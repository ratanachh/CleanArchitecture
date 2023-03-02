using AutoMapper;
using Inventory.Infrastructure.Models.Audit;
using Inventory.Application.Responses.Audit;

namespace Inventory.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}