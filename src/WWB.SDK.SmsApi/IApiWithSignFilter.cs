using WebApiClientCore.Attributes;

namespace WWB.SDK.SmsApi
{
    [JsonNetReturn(EnsureMatchAcceptContentType = false)]
    [SignApiFilter]
    [LoggingFilter]
    public interface IApiWithSignFilter
    {
        
    }
}