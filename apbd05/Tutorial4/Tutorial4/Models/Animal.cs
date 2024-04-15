namespace Tutorial4.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string Color { get; set; }
    
    public Animal() { }

    public Animal(int id,string name, string category, double weight, string color)
    {
        Id = id;
        Name = name;
        Category = category;
        Weight = weight;
        Color = color;
    }

    public override string ToString()
    {
        return $"ID: {Id}, AnimalName: {Name}, AnimalCategory: {Category}, " +
               $"AnimalWeight: {Weight}, AnimalColor: {Color}";
    }
}