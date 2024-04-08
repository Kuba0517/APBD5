using APBD5.Models;
using APBD5.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APBD5.Controllers;

[ApiController]
[Route("/visits")]
public class VisitsController : ControllerBase
{
    private IMockDbVisits _mockDb;

    public VisitsController(IMockDbVisits mockDb)
    {
        _mockDb = mockDb;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_mockDb.Get());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetVisitList(int id)
    {
        ICollection<Visit> visits = _mockDb.GetVisitList(id);
        if (visits.Count == 0) return NotFound();
        return Ok(visits);
    }
    
    
}