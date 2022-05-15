using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class User
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(128)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(100)]
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
    }
}