using System.Collections.Generic;

namespace Likja.ImgurNet.Models
{
    public class Conversation
    {
        public long Id { get; set; }
        public string LastMessagePreview { get; set; }
        public long DateTime { get; set; }
        public long WithAccountId { get; set; }
        public string WithAccount { get; set; }
        public long MessageCount { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public bool Done { get; set; }
    }
}
