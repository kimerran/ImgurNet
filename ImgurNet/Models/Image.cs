﻿namespace Likja.ImgurNet.Models
{
    public class Image
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long DateTime { get; set; }
        public string Type { get; set; }
        public bool Animated { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public long Size { get; set; }
        public long Views { get; set; }
        public long Bandwidth { get; set; }
        public string DeleteHash { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public string Link { get; set; }
        public string Gifv { get; set; }
        public string Mp4 { get; set; }
        public string Webm { get; set; }
        public bool Looping { get; set; }
        public bool? Favorite { get; set; }
        public bool? Nsfw { get; set; }
        public string Vote { get; set; }
        public string AccountUrl { get; set; }
    }
}
