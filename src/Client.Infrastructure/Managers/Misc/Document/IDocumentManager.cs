using Inventory.Application.Features.Documents.Commands.AddEdit;
using Inventory.Application.Features.Documents.Queries.GetAll;
using Inventory.Application.Requests.Documents;
using Inventory.Shared.Wrapper;
using System.Threading.Tasks;
using Inventory.Application.Features.Documents.Queries.GetById;

namespace Inventory.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}