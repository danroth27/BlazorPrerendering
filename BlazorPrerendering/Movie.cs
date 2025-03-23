using System.ComponentModel.DataAnnotations;

namespace BlazorMovieApp.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    public required string Title { get; set; }
    
    public DateOnly? ReleaseDate { get; set; }
    
    public string? Genre { get; set; }
    
    [Range(0, 100)]
    public decimal Price { get; set; }
}