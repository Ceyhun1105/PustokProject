﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace PustokImagesUploadTask.Areas.Admin.ViewModels
{
    public class AdminLoginViewModel
    {

        
        [Required]
        [StringLength(maximumLength: 30)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 20,MinimumLength =8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
