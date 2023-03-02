using System.Text.Json;
using Inventory.Application.Interfaces.Serialization.Options;

namespace Inventory.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}