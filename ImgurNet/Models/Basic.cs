using System;

namespace Likja.ImgurNet.Models
{
    public class Basic
    {
        public dynamic Data { get; set; }
        public bool Success { get; set; }
        public long Status { get; set; }

        public static Basic CreateFromDynamic(dynamic dynamicObject)
        {
            bool isSuccessful = dynamicObject.success;
            if (!isSuccessful) throw new Exception("Result is not successful");

            return new Basic
            {
                Data = dynamicObject.data,
                Status = dynamicObject.status,
                Success = dynamicObject.success
            };
        }
    }
}
