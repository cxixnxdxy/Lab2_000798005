using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lab1_000798005.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        //public string Email { get; set; }
        //public int PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
