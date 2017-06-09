namespace MovieSystem.App.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(100), Display(Name = "Title")]
        public string Title { get; set; }

        [Required, StringLength(100)]
        public string Director { get; set; }

        [Required, StringLength(10000), Display(Name = "Movie Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        //public string ImagePath { get; set; }
        [Required]
        public bool BasedOnBook { get; set; }

        public int? BookId { get; set; }

        public virtual ICollection<Genre> Genre { get; set; }

        public virtual ICollection<Actor> Actor { get; set; }

        public virtual Rank Rank { get; set; }

    }
}