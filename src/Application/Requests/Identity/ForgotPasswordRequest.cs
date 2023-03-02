﻿using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}