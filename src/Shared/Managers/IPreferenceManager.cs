using Inventory.Shared.Settings;
using System.Threading.Tasks;
using Inventory.Shared.Wrapper;

namespace Inventory.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}