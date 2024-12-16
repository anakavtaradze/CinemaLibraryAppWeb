using System.ComponentModel.DataAnnotations;


namespace CinemaLibraryApp.Models
{
    public class Movies
    { 
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate{ get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public Director Director { get; set; }

        public int Budget { get; set; }

        [Required]
        public string MoviePoster { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int IMBDrating { get; set; }

        [Required]
        public int RpttenTomatoesRating { get; set; }

        public List<Actor> Actors { get; set; }

    }
}
