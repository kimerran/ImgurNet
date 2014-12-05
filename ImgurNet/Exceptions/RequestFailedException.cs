using System;

namespace Likja.ImgurNet.Exceptions
{
    class RequestFailedException : Exception
    {
        public RequestFailedException(Exception inner) 
            : base("API request failed", inner)
        {
        }
    }
}
