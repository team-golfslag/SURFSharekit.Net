// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

namespace SURFSharekit.Net.Exceptions;

public class IncorrectTokenException : Exception
{
    public IncorrectTokenException(string exceptionMessage)
        : base(exceptionMessage)
    {
    }

    public IncorrectTokenException(string exceptionMessage, Exception innerException)
        : base(exceptionMessage, innerException)
    {
    }
}
