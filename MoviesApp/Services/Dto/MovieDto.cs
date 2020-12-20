using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Services.Dto
{
    public class MovieDto
    {
        public int? Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}