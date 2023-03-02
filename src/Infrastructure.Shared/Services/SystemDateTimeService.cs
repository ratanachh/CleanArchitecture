using Inventory.Application.Interfaces.Services;
using System;

namespace Inventory.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}