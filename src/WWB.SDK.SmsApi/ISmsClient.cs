using System.Threading.Tasks;
using WebApiClientCore.Attributes;
using WWB.SDK.SmsApi.Models;
using WWB.UnifyApi.Models;

namespace WWB.SDK.SmsApi
{
    /// <summary>
    /// 短信平台客户端
    /// </summary>
    public interface ISmsClient : IApiWithSignFilter
    {
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpPost("create")]
        Task<ApiResult> Send([JsonNetContent] SendSmsRequest request);
    }
}