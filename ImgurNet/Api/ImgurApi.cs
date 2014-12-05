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
