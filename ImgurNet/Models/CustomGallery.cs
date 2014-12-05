namespace ImgurNet.Models
{
    public class CustomGallery
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long DateTime { get; set; }
        public string AccountUrl { get; set; }
        public string Link { get; set; }
        public string[] Tags { get; set; }
        public long ItemCount { get; set; }
        public object[] Items { get; set; }
    }
}
