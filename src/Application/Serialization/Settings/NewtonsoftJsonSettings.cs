
using Inventory.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace Inventory.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}