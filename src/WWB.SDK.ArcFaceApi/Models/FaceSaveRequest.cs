using System.ComponentModel.DataAnnotations;

namespace WWB.SDK.ArcFaceApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class FaceSaveRequest
    {
        /// <summary>
        /// 人脸特征标识
        /// </summary>
        [Required(ErrorMessage = "人脸特征标识不能为空")]
        public string Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage = "姓名不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Required(ErrorMessage = "手机号不能为空")]
        public string Phone { get; set; }

        /// <summary>
        /// 人脸特征
        /// </summary>
        [Required(ErrorMessage = "base64人脸特征不能为空")]
        public string Feature { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }
    }
}