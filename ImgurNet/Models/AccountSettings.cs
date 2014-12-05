namespace ImgurNet.Models
{
    public class AccountSettings
    {
        public string Email { get; set; }
        public bool HighQuality { get; set; }
        public bool PublicImages { get; set; }
        public string AlbumPrivacy { get; set; }
        public bool ProExpiration { get; set; }
        public bool AcceptedGalleryTerms { get; set; }
        public string[] ActiveEmails { get; set; }
        public bool MessagingEnabled { get; set; }
        public object[] BlockedUsers { get; set; }
    }
}
