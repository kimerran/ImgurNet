using System;
using System.Threading.Tasks;
using Flurl.Http;
using ImgurNet.Common;
using ImgurNet.Exceptions;
using ImgurNet.Extensions;
using ImgurNet.Models;

namespace ImgurNet
{
    public class ImgurNet
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        public ImgurNet(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        /// <summary>
        /// Get information about an image.
        /// </summary>
        /// <remarks>See: https://api.imgur.com/endpoints/image#image</remarks>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Image> ImageDetails(string id)
        {
            var url = ImgurUrls.ImageDetailsUrl(id);

            try
            {
                var result = await url
                    .WithImgurAuthHeader(_clientId)
                    .GetJsonAsync();

                var basic = Basic.CreateFromDynamic(result);
                return basic.CreateImage();
            }
            catch (Exception ex)
            {
                throw new RequestFailedException(ex);
            }

        }

        /// <summary>
        /// Upload a new image.
        /// </summary>
        /// <remarks>See: https://api.imgur.com/endpoints/image#image-upload</remarks>
        /// <param name="image"></param>
        /// <returns></returns>
        public async Task<Image> ImageUpload(ImageUpload image)
        {
            try
            {
                var results = await ImgurUrls.ImageUploadUrl()
                    .WithImgurAuthHeader(_clientId)
                    .PostJsonAsync(image)
                    .ReceiveJson();

                var basic = Basic.CreateFromDynamic(results);
                return basic.CreateImage();
            }
            catch (Exception ex)
            {
                throw new RequestFailedException(ex);
            }

        }
    }
}
