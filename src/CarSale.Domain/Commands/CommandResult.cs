using CarSale.Domain.Commands.Interfaces;

namespace CarSale.Domain.Commands;

public class CommandResult : ICommandResult
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }

    public CommandResult(bool success, string message, object data)
    {
        Success = success;
        Message = message;
        Data = data;
    }
}

public class CommandResult<T> : ICommandResult<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }

    public CommandResult(bool success, string message, T data)
    {
        Success = success;
        Message = message;
        Data = data;
    }
}