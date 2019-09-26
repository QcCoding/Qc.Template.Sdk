using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;

namespace Qc.QcProjectSdk
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseQcProjectSdk(this IApplicationBuilder app, Func<QcProjectConfig> configHandler)
        {
            return app;
        }
    }
}
