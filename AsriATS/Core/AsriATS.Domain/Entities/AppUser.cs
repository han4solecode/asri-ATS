using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AsriATS.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateOnly Dob { get; set; }

        [Required]
        public string Sex { get; set; }
    }
}