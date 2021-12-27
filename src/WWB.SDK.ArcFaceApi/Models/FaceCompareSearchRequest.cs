using System.ComponentModel.DataAnnotations;

namespace WWB.SDK.ArcFaceApi.Models
{
    public class FaceCompareSearchRequest
    {
        /// <summary>
        /// 标识
        /// </summary>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// 图片base64字符串
        /// </summary>
        [Required]
        public string ImageStr { get; set; }
    }
}