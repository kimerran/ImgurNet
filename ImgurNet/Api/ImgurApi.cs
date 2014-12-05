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
    public partial class ImgurApi
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        public ImgurApi(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }
    }
}
