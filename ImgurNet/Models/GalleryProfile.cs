using System.Collections.Generic;

namespace ImgurNet.Models
{
    public class GalleryProfile
    {
        public long TotalGalleryComments { get; set; }
        public long TotalGalleryFavorites { get; set; }
        public long TotalGallerySubmissions { get; set; }
        public IEnumerable<Trophy> Trophies { get; set; }
    }
}
