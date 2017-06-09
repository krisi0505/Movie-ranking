namespace MovieSystem.App.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Actor
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}