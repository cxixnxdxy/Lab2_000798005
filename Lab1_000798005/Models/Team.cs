using System.ComponentModel.DataAnnotations;

namespace Lab1_000798005.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name ="Team Name")]
        public string TeamName { get; set; }
        [Required]
        public string Email { get; set; }

        [Display(Name ="Established Date")]
        public DateTime? EstablishedDate { get; set; }
    }
}
