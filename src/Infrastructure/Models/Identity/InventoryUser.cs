﻿using Inventory.Domain.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Inventory.Application.Interfaces.Chat;
using Inventory.Application.Models.Chat;

namespace Inventory.Infrastructure.Models.Identity
{
    public class InventoryUser : IdentityUser<string>, IChatUser, IAuditableEntity<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CreatedBy { get; set; }

        [Column(TypeName = "text")]
        public string ProfilePictureDataUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public virtual ICollection<ChatHistory<InventoryUser>> ChatHistoryFromUsers { get; set; }
        public virtual ICollection<ChatHistory<InventoryUser>> ChatHistoryToUsers { get; set; }

        public InventoryUser()
        {
            ChatHistoryFromUsers = new HashSet<ChatHistory<InventoryUser>>();
            ChatHistoryToUsers = new HashSet<ChatHistory<InventoryUser>>();
        }
    }
}