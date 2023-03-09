using Flunt.Notifications;

namespace CarSale.Domain.Entities;

public abstract class Entity : Notifiable<Notification>
{
    public int Id { get; private set; }

    protected Entity()
    {
        Id = 0;
    }
}