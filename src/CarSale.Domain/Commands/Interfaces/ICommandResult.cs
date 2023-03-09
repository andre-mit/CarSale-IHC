namespace CarSale.Domain.Commands.Interfaces;

public interface ICommandResult
{
    bool Success { get; set; }
    string Message { get; set; }
    object Data { get; set; }
}

public interface ICommandResult<T>
{
    bool Success { get; set; }
    string Message { get; set; }
    T Data { get; set; }
}