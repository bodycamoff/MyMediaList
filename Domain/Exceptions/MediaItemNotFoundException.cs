namespace Domain.Exceptions;

public class MediaItemNotFoundException : Exception
{
    public MediaItemNotFoundException(string message) : base(message)
    {
    }
}