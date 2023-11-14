namespace ShamsheerClone.Service.Exceptions;

public class ShamsheerCloneException : Exception
{
    public int StatusCode { get; set; }
    public ShamsheerCloneException(int code, string message) : base(message)
    {
        StatusCode = code;
    }
}
