using APBD5.Models;
using APBD5.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace APBD5.Controllers;

[ApiController]
[Route("/animals")]
public class AnimalsController : ControllerBase
{
    private IMockDbAnimals _mockDb;

    public AnimalsController(IMockDbAnimals mockDb)
    {
        _mockDb = mockDb;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_mockDb.GetAll());
    }
    
    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        return Ok(_mockDb.Get(id));
    }

    [HttpPost]
    public IActionResult Add(Animal animal)
    {
        _mockDb.Add(animal);
        return Created();
    }

    [HttpPut("{id:int}")]
    public IActionResult Edit(Animal animal, int id)
    {
        if (_mockDb.Get(id) == null) return NotFound();
       _mockDb.Update(id, animal);
       return Created();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        if (_mockDb.Get(id) == null) return NotFound();
        _mockDb.Delete(id);
        return Ok();

    }

}