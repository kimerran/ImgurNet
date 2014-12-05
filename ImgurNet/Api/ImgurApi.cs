using System;
using System.Threading.Tasks;
using Flurl.Http;
using Likja.ImgurNet.Common;
using Likja.ImgurNet.Exceptions;
using Likja.ImgurNet.Extensions;
using Likja.ImgurNet.Mapping;
using Likja.ImgurNet.Models;

namespace Likja.ImgurNet.Api
{
    public class ImgurApi
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        public ImgurApi(string clientId, string clientSecret)
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
            var url = ImgurUrls.ImageIdUrl(id);

            try
            {
                var result = await url.WithImgurAuthHeader(_clientId)
                    .GetJsonAsync();

                var basic = Mapper.Map<Basic>(result);
                return Mapper.Map<Image>(basic.Data);
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
            var url = ImgurUrls.ImageUrl();

            try
            {
                var result = await url.WithImgurAuthHeader(_clientId)
                    .PostJsonAsync(image)
                    .ReceiveJson();

                var basic = Mapper.Map<Basic>(result);
                return Mapper.Map<Image>(basic.Data);
            }
            catch (Exception ex)
            {
                throw new RequestFailedException(ex);
            }

        }
    }
}
