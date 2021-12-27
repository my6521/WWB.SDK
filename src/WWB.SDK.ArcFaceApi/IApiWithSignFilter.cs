using WebApiClientCore.Attributes;

namespace WWB.SDK.ArcFaceApi
{
    [JsonNetReturn(EnsureMatchAcceptContentType = false)]
    [SignApiFilter]
    [LoggingFilter]
    public interface IApiWithSignFilter
    {
        
    }
}