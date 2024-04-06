using APBD5.Models;

namespace APBD5.Repositories;

public class MockDbAnimals : IMockDbAnimals
{
    private ICollection<Animal> _animals;

    public MockDbAnimals()
    {
        _animals = new List<Animal>()
        {
            new Animal()
            {
                ID = 1,
                Imie = "Puszek",
                AnimalType = "Cat",
                Weight = 10.5,
                FurColor = "Black",
            },
            new Animal()
            {
                ID = 2,
                Imie = "Toffik",
                AnimalType = "Dog",
                Weight = 15.5,
                FurColor = "Brown",
            },
            new Animal()
            {
                ID = 3,
                Imie = "Nugat",
                AnimalType = "Shark",
                Weight = 150.23,
                FurColor = "Grey",
            },
            new Animal()
            {
                ID = 4,
                Imie = "Frytka",
                AnimalType = "Lion",
                Weight = 120.5,
                FurColor = "Ginger",
            },
            new Animal()
            {
                ID = 5,
                Imie = "Mruczek",
                AnimalType = "Cat",
                Weight = 5.5,
                FurColor = "White",
            },
            new Animal()
            {
                ID = 6,
                Imie = "Reksio",
                AnimalType = "Dog",
                Weight = 20.0,
                FurColor = "Black",
            },
            new Animal()
            {
                ID = 7,
                Imie = "Goldie",
                AnimalType = "Dog",
                Weight = 25.543,
                FurColor = "Black",
            },
            new Animal()
            {
                ID = 8,
                Imie = "Shadow",
                AnimalType = "Cat",
                Weight = 8.0,
                FurColor = "Grey",
            },
            new Animal()
            {
                ID = 9,
                Imie = "Bella",
                AnimalType = "Dog",
                Weight = 18.0,
                FurColor = "Ginger",
            },
            new Animal()
            {
                ID = 10,
                Imie = "Zebra",
                AnimalType = "Lion",
                Weight = 90.0,
                FurColor = "Brown",
            },
            new Animal()
            {
                ID = 11,
                Imie = "Simba",
                AnimalType = "Lion",
                Weight = 150.0,
                FurColor = "Ginger",
            },
            new Animal()
            {
                ID = 12,
                Imie = "Lucky",
                AnimalType = "Cat",
                Weight = 2.5,
                FurColor = "White",
            },
            new Animal()
            {
                ID = 13,
                Imie = "Patch",
                AnimalType = "Dog",
                Weight = 22.5,
                FurColor = "White",
            },
            new Animal()
            {
                ID = 14,
                Imie = "Sonic",
                AnimalType = "Shark",
                Weight = 1.0,
                FurColor = "Grey",
            },
            new Animal()
            {
                ID = 15,
                Imie = "Flash",
                AnimalType = "Tiger",
                Weight = 30.0,
                FurColor = "Ginger",
            }
        };
    }

    public ICollection<Animal> GetAll()
    {
        return _animals;
    }

    public Animal? Get(int id)
    {
        return _animals.FirstOrDefault(animal => animal.ID == id);
    }

    public void Add(Animal animal)
    {
        _animals.Add(animal);
    }

    public void Update(int id, Animal animal)
    {
        var foundAnimal = Get(id);
        if (foundAnimal == null) return;
        foundAnimal.ID = animal.ID;
        foundAnimal.Imie = animal.Imie;
        foundAnimal.AnimalType = animal.AnimalType;
        foundAnimal.FurColor = animal.FurColor;
        foundAnimal.Weight = animal.Weight;
    }

    public void Delete(int id)
    {
        var animal = Get(id);
        if(animal == null) return;
        _animals.Remove(animal);
    }
}
