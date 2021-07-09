using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{ 
    public class Login{

        [Required]
        [EmailAddress]
        [Display(Name = "Login Email")]
        public string LoginEmail { get; set; }
        
        [Required]
        [Display(Name = "Login Password")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }

    }}
        