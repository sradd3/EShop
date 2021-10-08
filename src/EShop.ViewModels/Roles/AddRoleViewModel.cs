﻿using System.ComponentModel.DataAnnotations;
using EShop.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace EShop.ViewModels.Roles
{
    public class AddRoleViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
        [MaxLength(100, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
        [Remote("CheckRoleName", "Role", "Admin",
            ErrorMessage = AttributesErrorMessages.RemoteMessage, HttpMethod = "POST")]
        public string Name { get; set; }
    }
}