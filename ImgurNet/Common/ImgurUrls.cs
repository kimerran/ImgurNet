using Flurl;
using ImgurNet.Extensions;

namespace ImgurNet.Common
{
    internal static class ImgurUrls
    {
        private const string BaseApiUrl = "https://api.imgur.com/3";

        internal static Url ImageIdUrl(string id)
        {
            return BaseApiUrl.AppendPathFormat("image/{0}", id);
        }

        internal static Url ImageUrl()
        {
            return BaseApiUrl.AppendPathSegment("image");
        }
    }
}
