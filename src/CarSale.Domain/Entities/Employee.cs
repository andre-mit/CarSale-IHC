using CarSale.Domain.Enums;

namespace CarSale.Domain.Entities;

public class Employee : Entity
{
    public string Name { get; private set; }
    public Position Position { get; private set; }
    public List<Sale> Sales { get; private set; }

    public Employee(string name, Position position, List<Sale> sales)
    {
        Name = name;
        Position = position;
        Sales = sales;
    }
}
