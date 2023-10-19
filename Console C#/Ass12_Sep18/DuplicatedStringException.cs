using System.Runtime.Serialization;

[Serializable]
internal class DuplicatedStringException : Exception
{
    public DuplicatedStringException()
    {
    }

    public DuplicatedStringException(string? message) : base(message)
    {
    }

    public DuplicatedStringException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected DuplicatedStringException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}