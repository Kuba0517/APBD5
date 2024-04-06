namespace APBD5.Models;

public class Animal
{
    public int ID { get; set; }
    public string Imie { get; set; }
    public AnimalType AnimalType { get; set; }
    public double Weight { get; set; }
    public FurColor FurColor { get; set; }
}


public enum AnimalType
{
    Dog,
    Cat,
    Tiger,
    Lion,
    Shark
}

public enum FurColor
{
    Ginger,
    Black,
    White,
    Grey,
    Brown
}