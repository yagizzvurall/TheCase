using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheCase.Data;
using TheCase.Data.Entities;

namespace TheCase.V1.Controller;

[ApiController]
[Produces("application/json")]
[Route("level")]
public class SuspiciousController : ControllerBase
{
    private readonly ApplicationDbContext _applicationDbContext;

    public SuspiciousController(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(QueryLevelResponse))]
    public async Task<IActionResult> QuerySuspiciousQuestion([FromQuery] QueryLevelRequest request)
    {
        var query = _applicationDbContext.Levels.AsQueryable();
         
        if (request.LevelId > 0)
        {
            query = query.Where(s => s.LevelId == request.LevelId);
        }

        if (!string.IsNullOrEmpty(request.LevelName))
        {
            query = query.Where(s => s.LevelName.Contains(request.LevelName));
        }

        List<QueryLevelResponse> response =await query.Select(level => new QueryLevelResponse()
        {
            LevelId = level.LevelId,
            LevelName = level.LevelName
        }).ToListAsync();
         
        return Ok(response) ;
    }
}