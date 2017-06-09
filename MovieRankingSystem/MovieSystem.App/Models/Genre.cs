namespace MovieSystem.App.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Genre
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50), Display(Name = "Genre")]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}