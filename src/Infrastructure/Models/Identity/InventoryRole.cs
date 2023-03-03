using System;
using System.Collections.Generic;
using Inventory.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Inventory.Infrastructure.Models.Identity
{
    public class InventoryRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<InventoryRoleClaim> RoleClaims { get; set; }

        public InventoryRole() : base()
        {
            RoleClaims = new HashSet<InventoryRoleClaim>();
        }

        public InventoryRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<InventoryRoleClaim>();
            Description = roleDescription;
        }
    }
}