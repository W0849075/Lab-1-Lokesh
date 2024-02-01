using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Lab_1_Lokesh.Models
{
    public class MovieGenreViewModel
    {
        public List<LokeshMovie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
