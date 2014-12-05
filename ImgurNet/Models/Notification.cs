namespace ImgurNet.Models
{
    public class Notification
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public bool Viewed { get; set; }
        public object Content { get; set; }
    }
}
