namespace Likja.ImgurNet.Models
{
    public class Message
    {
        public long Id { get; set; }
        public string From { get; set; }
        public long AccountId { get; set; }
        public long SenderId { get; set; }
        public string Body { get; set; }
        public long ConversationId { get; set; }
        public long DateTime { get; set; }
    }
}
