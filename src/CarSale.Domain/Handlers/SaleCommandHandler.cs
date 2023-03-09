using CarSale.Domain.Commands.Sale;
using MediatR;

namespace CarSale.Domain.Handlers;

public class SaleCommandHandler : IRequestHandler<CreateSaleCommand>
{
    public async Task Handle(CreateSaleCommand request, CancellationToken cancellationToken)
    {
        await Task.FromException(new NotImplementedException());
    }
}