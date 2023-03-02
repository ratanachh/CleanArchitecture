using Inventory.Application.Requests.Mail;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}