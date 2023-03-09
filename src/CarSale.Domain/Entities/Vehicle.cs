namespace CarSale.Domain.Entities;

public class Vehicle : Entity
{
    public string Model { get; private set; }
    public int Year { get; private set; }
    public string Color { get; private set; }
    public decimal Price { get; private set; }
    public bool Available { get; private set; }
    public List<Optional> Optionals { get; private set; }

    public Vehicle(string model, int year, string color, decimal price, bool available, List<Optional> optionals)
    {
        Model = model;
        Year = year;
        Color = color;
        Price = price;
        Available = available;
        Optionals = optionals;
    }
}