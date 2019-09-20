using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace QcProjectSdk
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加微信公众号 SDK，注入自定义实现的IQcProjectSdkHook
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddQcProjectSdk(this IServiceCollection services, Action<QcProjectConfig> optionsAction)
        {
            services.AddQcProjectSdk<DefaultQcProjectSdkHook>(optionsAction);

            return services;
        }
        /// <summary>
        /// 添加微信公众号 SDK
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddQcProjectSdk<T>(this IServiceCollection services, Action<QcProjectConfig> optionsAction = null) where T : class, IQcProjectSdkHook
        {
            if (optionsAction != null)
            {
                services.Configure(optionsAction);
            }
            services.AddScoped<IQcProjectSdkHook, T>();
            services.AddScoped<QcProjectService, QcProjectService>();
            services.AddHttpClient();
            return services;
        }
    }
}
