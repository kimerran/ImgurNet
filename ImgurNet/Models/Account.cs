namespace ImgurNet.Models
{
    public class Account
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public string Bio { get; set; }
        public float Reputation { get; set; }
        public long Created { get; set; }
        public bool ProExpiration { get; set; }
    }
}
