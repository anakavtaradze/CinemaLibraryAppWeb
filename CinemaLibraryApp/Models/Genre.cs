﻿using System.ComponentModel.DataAnnotations;

namespace CinemaLibraryApp.Models


{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
