using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace La3bni.UI
{
    public class Email
    {
        [Required(ErrorMessage ="Please Enter your Name!")]
        [Display(Name = "Name"),MinLength(7, ErrorMessage ="Name must be more than 7 charachters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter your Email Address!")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Please Enter Message to send!")]
        [Display(Name = "Message"), MinLength(20, ErrorMessage = "Message must be at least 20 charachters!")]
        public string Message { get; set; }
    }
}
