using System.ComponentModel.DataAnnotations;

namespace WWB.SDK.ArcFaceApi.Models
{
    public class FaceCompareSearchRequest
    {
        /// <summary>
        /// 标识
        /// </summary>
        [Required(ErrorMessage = "不包含标识不能为空")]
        public string ExcludeId { get; set; }

        /// <summary>
        /// 图片base64字符串
        /// </summary>
        [Required(ErrorMessage = "照片不能为空")]
        public string ImageStr { get; set; }

        /// <summary>
        /// 判断是否重复
        /// </summary>
        public bool ValidRepeat { get; set; } = true;
    }
}