namespace CarSale.Domain.Entities;

public class Customer: Entity
{
    public string Name { get; private set; }
    public string Phone { get; private set; }
    public string Address { get; private set; }
    public List<Sale> Sales { get; private set; }

    public Customer(string name, string phone, string address, List<Sale> sales)
    {
        Name = name;
        Phone = phone;
        Address = address;
        Sales = sales;
    }
}