// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

namespace SURFSharekit.Net.Exceptions;

public class ResultIsNullException : Exception
{
    public ResultIsNullException(string exceptionMessage)
        : base(exceptionMessage)
    {
    }

    public ResultIsNullException(string exceptionMessage, Exception innerException)
        : base(exceptionMessage, innerException)
    {
    }
}
