// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using TheCase.Controller.Request;
// using TheCase.Data;
// using TheCase.Data.Entities;
// //
// namespace TheCase.Controller;
// [ApiController]
// [Produces("application/json")]
// [Route("v1/suspicious")]
// public class SuspiciousController : ControllerBase
// {
//     private readonly ApplicationDbContext _applicationDbContext;
//
//     public SuspiciousController(ApplicationDbContext applicationDbContext)
//     {
//         _applicationDbContext = applicationDbContext;
//     }
//
     // [HttpGet]
     // [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(QuerySuspiciousQuestionResponse))]
     // public async Task<IActionResult> QuerySuspiciousQuestion(QuerySuspiciousQuestionRequest request)
     // {
     //     var query = _applicationDbContext.Suspiciouses.AsQueryable();
     //     
     //     if (request.SuspiciousId > 0)
     //     {
     //         query = query.Where(s => s.SuspiciousId == request.SuspiciousId);
     //     }
     //
     //     if (!string.IsNullOrEmpty(request.Name))
     //     {
     //         query = query.Where(s => s.Name.Contains(request.Name));
     //     }
     //
     //     if (!string.IsNullOrEmpty(request.Surname))
     //     {
     //         query = query.Where(s => s.Surname.Contains(request.Surname));
     //     }
     //
     //     if (request.LevelId > 0)
     //     {
     //         query = query.Where(s => s.LevelId == request.LevelId);
     //     }
     //
     //     if (request.Status.HasValue)
     //     {
     //         query = query.Where(s => s.Status == request.Status);
     //     }
     //     
     //     List<Suspicious> suspiciousList = await query.Include(s => s.Question).ToListAsync();
     //
     //     List<QuerySuspiciousQuestionResponse> response = suspiciousList.Select(s => new QuerySuspiciousQuestionResponse
     //     {
     //         SuspiciousId = s.SuspiciousId,
     //         Name = s.Name,
     //         Surname = s.Surname,
     //         LevelId = s.LevelId,
     //         Age = s.Age,
     //         Status = s.Status,
     //         RelationDegree = s.RelationDegree,
     //         Question = s.Question
     //     }).ToList();
     //     
     //     return Ok(response) ;
     // }
// }