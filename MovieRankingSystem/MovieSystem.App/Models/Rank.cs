namespace MovieSystem.App.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Rank
    {
        [Required]
        public int Id { get; set; }

        [Required,StringLength(50), Display(Name = "Rank")]
        public string Name { get; set; }
    }
}