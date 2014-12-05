using System.Collections.Generic;

namespace ImgurNet.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public string ImageId { get; set; }
        public string CommentDetails { get; set; }
        public string Author { get; set; }
        public long AuthorId { get; set; }
        public bool OnAlbum { get; set; }
        public string AlbumCover { get; set; }
        public long Ups { get; set; }
        public long Downs { get; set; }
        public float Points { get; set; }
        public long DateTime { get; set; }
        public long ParentId { get; set; }
        public bool Deleted { get; set; }
        public string Vote { get; set; }
        public IEnumerable<Comment> Children { get; set; }
    }
}
