using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WWB.SDK.SmsApi.Models
{
    /// <summary>
    /// 发送短信请求对象
    /// </summary>
    public class SendSmsRequest
    {
        /// <summary>
        /// 使用场景code定义
        /// </summary>
        [Required(ErrorMessage = "code不能为空")]
        [MaxLength(32,ErrorMessage = "长度不能超过32个字符")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Required(ErrorMessage = "手机号不能为空")]
        public string PhoneNumbers { get; set; }

        /// <summary>
        /// json参数
        /// </summary>
        public Dictionary<string,string> TemplateParams { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [Required(ErrorMessage = "密钥不能为空")]
        public string Secret { get; set; }
    }
}