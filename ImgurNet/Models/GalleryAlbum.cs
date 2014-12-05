using System.Collections.Generic;

namespace ImgurNet.Models
{
    public class GalleryAlbum
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long DateTime { get; set; }
        public string Cover { get; set; }
        public long CoverWidth { get; set; }
        public long CoverHeight { get; set; }
        public string AccountUrl { get; set; }
        public long AccountId { get; set; }
        public string Privacy { get; set; }
        public string Layout { get; set; }
        public long Views { get; set; }
        public string Link { get; set; }
        public long Ups { get; set; }
        public long Downs { get; set; }
        public long Score { get; set; }
        public bool IsAlbum { get; set; }
        public string Vote { get; set; }
        public bool Favorite { get; set; }
        public bool Nsfw { get; set; }
        public long ImagesCount { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}
