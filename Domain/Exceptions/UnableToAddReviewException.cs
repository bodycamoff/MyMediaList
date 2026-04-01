namespace Domain.Exceptions;

public class UnableToAddReviewException : Exception
{
    public UnableToAddReviewException(string message) : base(message)
    {
    }
}