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
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// 人脸特征
        /// </summary>
        [Required]
        public string FeatureBase64Str { get; set; }
    }
}