using BlazorMovieApp.Models;

namespace BlazorMovieApp.Services;
public interface IMovieService
{
    Task<List<Movie>> GetMoviesAsync(string? query = null);
}