using System;
using Microsoft.Extensions.DependencyInjection;

namespace WWB.SDK.ArcFaceApi
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddArcFaceApi(this IServiceCollection services, Action<ArcFaceClientConfig> setup)
        {
            var config = new ArcFaceClientConfig();
            setup?.Invoke(config);
            services.AddSingleton(config);
            
            if (string.IsNullOrWhiteSpace(config.Secret))
            {
                throw new ArgumentNullException("短信平台Secret不能为空");
            }
            if (string.IsNullOrWhiteSpace(config.Endpoint))
            {
                throw new ArgumentNullException("短信平台Host不能为空");
            }
            
            services.AddHttpApi<IArcFaceApi>(c =>
            {
                c.HttpHost = new Uri(config.Endpoint);
            });

            return services;
        }
    }
}