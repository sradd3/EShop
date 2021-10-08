﻿using System.ComponentModel.DataAnnotations;
using EShop.Common.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EShop.ViewModels.Application
{
    public abstract class GoogleReCaptchaModel
    {
        [Required]
        [GoogleReCaptchaValidation]
        [BindProperty(Name = "g-recaptcha-response")]
        public string GoogleReCaptchaResponse { get; set; }
    }
}
