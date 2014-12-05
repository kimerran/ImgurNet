using System;
using ImgurNet.Models;

namespace ImgurNet.Mapping
{
    public class Mapper
    {
        public static T Map<T>(dynamic resultData) where T : class
        {
            var typeParam = typeof(T);

            try
            {
                switch (typeParam.Name)
                {
                    case "Account":
                        return (T)Convert.ChangeType(MapAccount(resultData), typeParam);
                    case "Image":
                        return (T)Convert.ChangeType(MapImage(resultData), typeParam);
                }

                throw new Exception("Type mapping not currently supported.");

            }
            catch (Exception ex)
            {
                throw new Exception("Mapping failed.", ex);
            }
        }


        /// <summary>
        /// Tries to convert result data to Image object
        /// </summary>
        /// <returns></returns>
        private static Image MapImage(dynamic data)
        {
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

        /// <summary>
        /// Tries to convert result data to Account object
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static Account MapAccount(dynamic data)
        {
            return new Account
            {
                Id = data.id,
                Url = data.url,
                Bio = data.bio,
                Reputation = data.reputation,
                Created = data.created,
                ProExpiration = data.pro_expiration
            };
        }
    }
}
