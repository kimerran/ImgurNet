namespace ImgurNet.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public long Followers { get; set; }
        public long TotalItems { get; set; }
        public object[] Following { get; set; }
        public object[] Items { get; set; }
    }
}
