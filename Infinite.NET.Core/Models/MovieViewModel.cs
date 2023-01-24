using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infinite.NET.Core.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please provide movie name")]
        [Display(Name ="Movie Name")]
        public string MovieName { get; set; }

        public string ProductionName { get; set; }
        [Required(ErrorMessage ="Please provide valid release date")]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }
        //public GenreViewModel Genre { get; set; }

        [Required]
        [Display(Name ="Genre")]
        public int GenreId { get; set; }

        public string GenreName { get; set; }
    }
}
