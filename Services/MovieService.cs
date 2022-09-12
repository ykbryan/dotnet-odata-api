using dotnet_odata_api.Models;

namespace dotnet_odata_api.Services
{
    public class MovieService : IMovieService
    {
        public IQueryable<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}