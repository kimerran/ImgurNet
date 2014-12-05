using Newtonsoft.Json;

namespace ImgurNet.Models
{
    public class ImageUpload
    {
        [JsonProperty("image")]
        public dynamic Image { get; set; }

        [JsonProperty("type")]
        public ImageUploadType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public ImageUpload(ImageUploadType uploadType)
        {
            Type = uploadType;
        }
    }
}
