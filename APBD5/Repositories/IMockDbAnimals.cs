using APBD5.Models;

namespace APBD5.Repositories;

public interface IMockDbAnimals
{
    public ICollection<Animal> GetAll();
    public Animal? Get(int id);
    public void Add(Animal animal);
}