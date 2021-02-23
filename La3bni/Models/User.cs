using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class User
    {

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }



        [EmailAddress]
        [Key]
       
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public City City { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(11, ErrorMessage = "Not valid Number"),MaxLength(11 ,ErrorMessage ="Not valid Number")]
        public string PhoneNumber { get; set; }

        public string ImagePath { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }



    }



}
