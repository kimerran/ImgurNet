using Likja.ImgurNet.Api;
using Likja.ImgurNet.Models;
using NUnit.Framework;

namespace Likja.ImgurNet.Tests
{
    [TestFixture]
    public class ImgurNetTest
    {
        private ImgurApi imgur;
        static string CLIENT_ID = "566eded958e8044";
        static string CLIENT_SECRET = "6dcf529b52d4f93ba7e0439583831921117613e8";

        [SetUp]
        public void Setup()
        {
            imgur = new ImgurApi(CLIENT_ID, CLIENT_SECRET);
        }

        [Test]
        public async void ImageDetails_ShouldGetDetails()
        {
            var imageId = "QPjgZ7g";
            var result = await imgur.ImageDetails(imageId);

            Assert.IsNotNull(result);

        }

        [Test]
        public void ImageUpload_UsingUrl_ShouldCreateNewImage()
        {
            var image = new ImageUpload(ImageUploadType.Url)
            {
                Image = "http://img2.meetupstatic.com/img/8308650022681532654/header/logo-2x.png",
                Title = "Sample Image from ImgurNet",
                Description = "Description here from ImgurNet"
            };

            var result = imgur.ImageUpload(image);

            Assert.IsNotNull(result);
        }
    }
}
