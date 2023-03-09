namespace CarSale.Domain.Entities;

public class Optional : Entity
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public Vehicle Vehicle { get; private set; }

    public Optional(string name, decimal price, Vehicle vehicle)
    {
        Name = name;
        Price = price;
        Vehicle = vehicle;
    }
}
