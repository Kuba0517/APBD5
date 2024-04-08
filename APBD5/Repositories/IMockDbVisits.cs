using APBD5.Models;

namespace APBD5.Repositories;

public interface IMockDbVisits
{
    public List<Visit> GetVisitList(int animalId);
    public void Add(Visit visit);
    public ICollection<Visit> Get();

}