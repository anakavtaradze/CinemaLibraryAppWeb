using System.ComponentModel.DataAnnotations;

namespace CinemaLibraryApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Portrait { get; set; }

        public List<Movies> Movies { get; set; }
    }
}
