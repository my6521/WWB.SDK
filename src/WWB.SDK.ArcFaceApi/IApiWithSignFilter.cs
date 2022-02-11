using WebApiClientCore.Attributes;

namespace WWB.SDK.ArcFaceApi
{
    [JsonNetReturn(EnsureMatchAcceptContentType = false)]
    [SignApiFilter]
    public interface IApiWithSignFilter
    {
        
    }
}