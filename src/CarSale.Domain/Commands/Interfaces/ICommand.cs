using MediatR;

namespace CarSale.Domain.Commands.Interfaces;

public interface ICommand<T> : IRequest<T>
{
    void Validate();
}