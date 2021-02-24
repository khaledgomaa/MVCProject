﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImagePath { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }
        [Required]
        public City city { get; set; }
        [Required]
        public Gender gender { get; set; }
        [Required]
        public UserType Type { get; set; }

    }
    public enum Gender
    {
        Male, Female
    }
}
