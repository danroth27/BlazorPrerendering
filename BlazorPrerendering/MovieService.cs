using BlazorMovieApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieApp.Services;

public class MovieService : IMovieService
{
    private readonly List<Movie> movies =
    [
        new Movie { Id = 1, Title = "Inception", ReleaseDate = new DateOnly(2010, 7, 16), Genre = "Sci-Fi", Price = 9.99M },
        new Movie { Id = 2, Title = "The Matrix", ReleaseDate = new DateOnly(1999, 3, 31), Genre = "Action", Price = 8.99M },
        new Movie { Id = 3, Title = "Interstellar", ReleaseDate = new DateOnly(2014, 11, 7), Genre = "Sci-Fi", Price = 10.99M },
        new Movie { Id = 4, Title = "The Dark Knight", ReleaseDate = new DateOnly(2008, 7, 18), Genre = "Action", Price = 9.99M },
        new Movie { Id = 5, Title = "Fight Club", ReleaseDate = new DateOnly(1999, 10, 15), Genre = "Drama", Price = 8.99M },
        new Movie { Id = 6, Title = "Pulp Fiction", ReleaseDate = new DateOnly(1994, 10, 14), Genre = "Crime", Price = 7.99M },
        new Movie { Id = 7, Title = "Forrest Gump", ReleaseDate = new DateOnly(1994, 7, 6), Genre = "Drama", Price = 8.99M },
        new Movie { Id = 8, Title = "The Shawshank Redemption", ReleaseDate = new DateOnly(1994, 9, 23), Genre = "Drama", Price = 9.99M },
        new Movie { Id = 9, Title = "The Godfather", ReleaseDate = new DateOnly(1972, 3, 24), Genre = "Crime", Price = 9.99M },
        new Movie { Id = 10, Title = "The Godfather: Part II", ReleaseDate = new DateOnly(1974, 12, 20), Genre = "Crime", Price = 9.99M },
        new Movie { Id = 11, Title = "The Lord of the Rings: The Fellowship of the Ring", ReleaseDate = new DateOnly(2001, 12, 19), Genre = "Fantasy", Price = 9.99M },
        new Movie { Id = 12, Title = "The Lord of the Rings: The Two Towers", ReleaseDate = new DateOnly(2002, 12, 18), Genre = "Fantasy", Price = 9.99M },
        new Movie { Id = 13, Title = "The Lord of the Rings: The Return of the King", ReleaseDate = new DateOnly(2003, 12, 17), Genre = "Fantasy", Price = 9.99M },
        new Movie { Id = 14, Title = "Star Wars: Episode IV - A New Hope", ReleaseDate = new DateOnly(1977, 5, 25), Genre = "Sci-Fi", Price = 8.99M },
        new Movie { Id = 15, Title = "Star Wars: Episode V - The Empire Strikes Back", ReleaseDate = new DateOnly(1980, 5, 21), Genre = "Sci-Fi", Price = 8.99M },
        new Movie { Id = 16, Title = "Star Wars: Episode VI - Return of the Jedi", ReleaseDate = new DateOnly(1983, 5, 25), Genre = "Sci-Fi", Price = 8.99M },
        new Movie { Id = 17, Title = "The Matrix Reloaded", ReleaseDate = new DateOnly(2003, 5, 15), Genre = "Action", Price = 8.99M },
        new Movie { Id = 18, Title = "The Matrix Revolutions", ReleaseDate = new DateOnly(2003, 11, 5), Genre = "Action", Price = 8.99M },
        new Movie { Id = 19, Title = "Gladiator", ReleaseDate = new DateOnly(2000, 5, 5), Genre = "Action", Price = 8.99M },
        new Movie { Id = 20, Title = "Jurassic Park", ReleaseDate = new DateOnly(1993, 6, 11), Genre = "Adventure", Price = 7.99M },
        new Movie { Id = 21, Title = "The Lion King", ReleaseDate = new DateOnly(1994, 6, 24), Genre = "Animation", Price = 7.99M },
        new Movie { Id = 22, Title = "Back to the Future", ReleaseDate = new DateOnly(1985, 7, 3), Genre = "Sci-Fi", Price = 7.99M },
        new Movie { Id = 23, Title = "Terminator 2: Judgment Day", ReleaseDate = new DateOnly(1991, 7, 3), Genre = "Action", Price = 8.99M },
        new Movie { Id = 24, Title = "The Silence of the Lambs", ReleaseDate = new DateOnly(1991, 2, 14), Genre = "Thriller", Price = 8.99M },
        new Movie { Id = 25, Title = "Saving Private Ryan", ReleaseDate = new DateOnly(1998, 7, 24), Genre = "War", Price = 8.99M },
        new Movie { Id = 26, Title = "Schindler's List", ReleaseDate = new DateOnly(1993, 12, 15), Genre = "Drama", Price = 9.99M },
        new Movie { Id = 27, Title = "Braveheart", ReleaseDate = new DateOnly(1995, 5, 24), Genre = "War", Price = 8.99M },
        new Movie { Id = 28, Title = "The Green Mile", ReleaseDate = new DateOnly(1999, 12, 10), Genre = "Drama", Price = 8.99M },
        new Movie { Id = 29, Title = "Avatar", ReleaseDate = new DateOnly(2009, 12, 18), Genre = "Sci-Fi", Price = 9.99M },
        new Movie { Id = 30, Title = "Titanic", ReleaseDate = new DateOnly(1997, 12, 19), Genre = "Romance", Price = 9.99M },
        new Movie { Id = 31, Title = "The Avengers", ReleaseDate = new DateOnly(2012, 5, 4), Genre = "Action", Price = 9.99M },
        new Movie { Id = 32, Title = "Avengers: Endgame", ReleaseDate = new DateOnly(2019, 4, 26), Genre = "Action", Price = 9.99M },
        new Movie { Id = 33, Title = "Avengers: Infinity War", ReleaseDate = new DateOnly(2018, 4, 27), Genre = "Action", Price = 9.99M }
    ];

    public async Task<List<Movie>> GetMoviesAsync(string? query = null)
    {
        await Task.Delay(1000); // Add a 3-second delay to simulate a long-running API call

        var result = string.IsNullOrEmpty(query)
            ? movies
            : movies.Where(m => m.Title.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        return result;
    }
}