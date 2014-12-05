using System.Collections.Generic;

namespace ImgurNet.Models
{
    public class Album
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long DateTime { get; set; }
        public string Cover { get; set; }
        public long CoverWidth { get; set; }
        public long CoverHeight { get; set; }
        public string AccountUrl { get; set; }
        public string Privacy { get; set; }
        public string Layout { get; set; }
        public long Views { get; set; }
        public string Link { get; set; }
        public bool Favorite { get; set; }
        public bool Nsfw { get; set; }
        public string Section { get; set; }
        public long Order { get; set; }
        public string DeleteHash { get; set; }
        public long ImagesCount { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}
