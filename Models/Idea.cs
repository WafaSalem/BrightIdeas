
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{

    public class Idea{

        [Key]
        [Required]
        public int IdeaId { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Must be at least 5 characters")]
        public string NewIdea { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        // Foreign Key for UserId has to match the property name in User class
        public int UserId { get; set; }
        public User PostedBy { get; set; }
        public List<Like> Likedby { get; set; }

    }}