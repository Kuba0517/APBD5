using APBD5.Models;
using APBD5.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APBD5.Controllers;

[ApiController]
[Route("/visits")]
public class VisitsController : ControllerBase
{
    private IMockDbVisits _mockDbVisits;
    private IMockDbAnimals _mockDbAnimals;

    public VisitsController(IMockDbVisits mockDbVisits, IMockDbAnimals mockDbAnimals)
    {
        _mockDbVisits = mockDbVisits;
        _mockDbAnimals = mockDbAnimals;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_mockDbVisits.Get());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetVisitList(int id)
    {
        ICollection<Visit> visits = _mockDbVisits.GetVisitList(id);
        if (visits.Count == 0) return NotFound();
        return Ok(visits);
    }

    [HttpPost]
    public IActionResult Add(Visit visit)
    {
        _mockDbVisits.Add(visit);
        return Ok();
    }
}