using APBD5.Models;

namespace APBD5.Repositories;

public class MockDbVisits : IMockDbVisits
{
    private ICollection<Visit> _visits;
    private MockDbAnimals _dbAnimals;
    public MockDbVisits()
    {
        _dbAnimals = new MockDbAnimals();
        _visits = new List<Visit>()
        {
            new Visit()
            {
                Date = DateTime.Now.AddDays(-10),
                Animal = _dbAnimals.Get(1),
                Description = "Annual vaccination",
                Price = 120.50
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-20),
                Animal = _dbAnimals.Get(2),
                Description = "Deworming",
                Price = 80.99
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-30),
                Animal = _dbAnimals.Get(3),
                Description = "General check-up",
                Price = 100.00
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-5),
                Animal = _dbAnimals.Get(4),
                Description = "Skin allergy treatment",
                Price = 200.00
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-15),
                Animal = _dbAnimals.Get(5),
                Description = "Dental cleaning",
                Price = 250.00
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-3),
                Animal = _dbAnimals.Get(1),
                Description = "Emergency visit - leg injury",
                Price = 300.00
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-7),
                Animal = _dbAnimals.Get(2),
                Description = "Follow-up visit",
                Price = 90.00
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-1),
                Animal = _dbAnimals.Get(15),
                Description = "Nail trimming",
                Price = 50.00
            },
            new Visit()
            {
                Date = DateTime.Now.AddDays(-2),
                Animal = _dbAnimals.Get(14),
                Description = "Annual vaccination",
                Price = 120.50
            },
        };
    }

    public ICollection<Visit> Get()
    {
        return _visits;
    }

    public List<Visit> GetVisitList(int animalId)
    {
        return _visits.Where(visit => visit.Animal.ID == animalId).ToList();
    }

    public void Add(Visit visit)
    {
        _visits.Add(visit);
    }
}