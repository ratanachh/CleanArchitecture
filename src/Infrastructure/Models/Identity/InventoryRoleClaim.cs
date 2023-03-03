using System;
using Inventory.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Inventory.Infrastructure.Models.Identity
{
    public class InventoryRoleClaim : IdentityRoleClaim<string>, IAuditableEntity<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual InventoryRole Role { get; set; }

        public InventoryRoleClaim() : base()
        {
        }

        public InventoryRoleClaim(string roleClaimDescription = null, string roleClaimGroup = null) : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}