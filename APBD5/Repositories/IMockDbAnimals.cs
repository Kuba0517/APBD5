using APBD5.Models;

namespace APBD5.Repositories;

public interface IMockDbAnimals
{
    public ICollection<Animal> GetAll();
    public Animal? Get(int id);
    public void Add(Animal animal);
    public void Update(int id, Animal animal);
    public void Delete(int id);
}