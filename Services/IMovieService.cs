

using dotnet_odata_api.Models;

namespace dotnet_odata_api.Services
{
    public interface IMovieService
    {
        IQueryable<Movie> GetMovies();
    }
}