using System.Linq;
using Inventory.Shared.Constants.Localization;
using Inventory.Shared.Settings;

namespace Inventory.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}