using CarSale.Domain.Enums;

namespace CarSale.Domain.Entities;

public class Sale : Entity
{
    
    public DateTime Date { get; private set; }
    public decimal TotalValue { get; private set; }
    public PaymentMethod PaymentMethod { get; private set; }
    public Vehicle Vehicle { get; private set; }
    public List<Optional> Optionals { get; private set; }
    public Customer Customer { get; private set; }
    public Employee Employee { get; private set; }

    public Sale(DateTime date, decimal totalValue, PaymentMethod paymentMethod, Vehicle vehicle, List<Optional> optionals, Customer customer, Employee employee)
    {
        Date = date;
        TotalValue = totalValue;
        PaymentMethod = paymentMethod;
        Vehicle = vehicle;
        Optionals = optionals;
        Customer = customer;
        Employee = employee;
    }
}
