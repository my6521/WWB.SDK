using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace WWB.SDK.ArcFaceApi
{
    public class SignApiFilter : ApiFilterAttribute
    {
        public override Task OnRequestAsync(ApiRequestContext context)
        {
            var config = context.HttpContext.ServiceProvider.GetService<ArcFaceClientConfig>();

            context.HttpContext.RequestMessage.AddUrlQuery("sign", config.Secret);

            return Task.CompletedTask;
        }

        public override Task OnResponseAsync(ApiResponseContext context)
        {
            return Task.CompletedTask;
        }
    }
}