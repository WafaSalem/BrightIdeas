using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{ 
    public class User{
        [Key]
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        [Display(Name = "Name")]
        [RegularExpression(@"^[a-zA-Z ]+$",ErrorMessage="Please only letters and spaces")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Alias")]
        [RegularExpression(@"^[a-zA-Z0-9]+$",ErrorMessage="Please only letters and numbers")]
        public string Alias { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Confirm must be 8 characters or longer!")]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string Confirm { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Like> UserLikes {get; set;}
        public List<Idea> UsersIdeas {get; set;}

        
    }
}