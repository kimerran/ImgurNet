using Flurl;
using ImgurNet.Extensions;

namespace ImgurNet.Common
{
    internal static class ImgurUrls
    {
        private const string BaseApiUrl = "https://api.imgur.com/3";

        /// <summary>
        /// https://api.imgur.com/endpoints/image#image
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static Url ImageDetailsUrl(string id)
        {
            return BaseApiUrl.AppendPathFormat("image/{0}", id);
        }

        /// <summary>
        /// https://api.imgur.com/endpoints/image#image-upload
        /// </summary>
        /// <returns></returns>
        internal static Url ImageUploadUrl()
        {
            return BaseApiUrl.AppendPathSegment("image");
        }

        /// <summary>
        /// https://api.imgur.com/endpoints/image#image-delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static Url ImageDeletionUrl(string id)
        {
            return BaseApiUrl.AppendPathFormat("image/{0}", id);
        }

        /// <summary>
        /// https://api.imgur.com/endpoints/image#image-update
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static Url UpdateImageInformation(string id)
        {
            return BaseApiUrl.AppendPathFormat("image/{0}", id);
        }
    }
}
