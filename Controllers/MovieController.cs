using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using dotnet_odata_api.Databases;
using dotnet_odata_api.Models;
using dotnet_odata_api.Services;


namespace dotnet_odata_api.Controllers;

[ApiController]
[Route("movies")]
public class MovieController : ControllerBase
{
    private ApplicationDbContext _context;
    private readonly ILogger<MovieController> _logger;
    private readonly IMovieService _movieService;

    public MovieController(ApplicationDbContext context, ILogger<MovieController> logger, IMovieService movieService)
    {
        _context = context;
        _logger = logger;
        _movieService = movieService;
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<List<Movie>> Get()
    {
        return Ok(_context.Movie);
    }
}
