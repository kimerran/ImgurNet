using Flurl;
using Flurl.Http;

namespace ImgurNet.Extensions
{
    internal  static class StringExtensions
    {
        public static FlurlClient WithImgurAuthHeader(this Url url, string clientId)
        {
            return url.WithHeader("Authorization", "Client-ID " + clientId);
        }

        public static Url AppendPathFormat(this string url, string stringPattern, params object[] entities)
        {
            return url.AppendPathSegment(string.Format(stringPattern, entities));
        }
    }
}
