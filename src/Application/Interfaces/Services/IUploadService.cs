using Inventory.Application.Requests;

namespace Inventory.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}