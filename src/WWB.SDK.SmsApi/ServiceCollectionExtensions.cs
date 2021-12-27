using System;
using Microsoft.Extensions.DependencyInjection;

namespace WWB.SDK.SmsApi
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加短信服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="setup"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddSmsClient(this IServiceCollection services, Action<SmsClientConfig> setup)
        {
            var config = new SmsClientConfig();
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

            services
                .AddWebApiClient()
                .UseJsonFirstApiActionDescriptor();

            services.AddHttpApi<ISmsClient>(c =>
            {
                c.HttpHost = new Uri(config.Endpoint);
            });

            return services;
        }
    }
}