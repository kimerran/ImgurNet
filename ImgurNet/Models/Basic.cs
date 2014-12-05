using System;

namespace ImgurNet.Models
{
    public class Basic
    {
        public dynamic Data { get; set; }
        public bool Success { get; set; }
        public long Status { get; set; }


        public static Basic CreateFromDynamic(dynamic dynamicObject)
        {
            bool isSuccessful = dynamicObject.success;
            if(!isSuccessful) throw new Exception("Result is not successful");

            return new Basic
            {
                Data = dynamicObject.data,
                Status = dynamicObject.status,
                Success = dynamicObject.success
            };
        }

        /// <summary>
        /// Converts basic data to Image if possible
        /// </summary>
        /// <returns></returns>
        public Image CreateImage()
        {
            var data = Data;
            return new Image
            {
                Id = data.id,
                Title = data.title,
                Description = data.description,
                DateTime = data.datetime,
                Type = data.type,
                Animated = data.animated,
                Width = data.width,
                Height = data.height,
                Size = data.size,
                Views = data.views,
                Bandwidth = data.bandwidth,
                //DeleteHash = data.deletehash ?? "" , #owner only
                //Name = data.name, #owner only
                Section = data.section,
                Link = data.link,
               // Gifv = data.gifv, 
                //Mp4 = data.mp4,
               // Webm = data.webm,
                //Looping = data.looping, # gif only
                Favorite = data.favorite,
                Nsfw = data.nsfw,
                Vote = data.vote,
                AccountUrl = data.account_url
            };
        }

    }
}
