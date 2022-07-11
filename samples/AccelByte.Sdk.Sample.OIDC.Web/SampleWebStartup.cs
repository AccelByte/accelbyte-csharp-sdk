// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AccelByte.Sdk.Sample.OIDC.Web
{
    public class SampleWebStartup
    {
        public SampleWebStartup()
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app
                .UseDefaultFiles()
                .UseStaticFiles()
                .UseMiddleware<SampleWebAPIMiddleware>()
                .Run((context) =>
                {
                    return Task.CompletedTask;
                });
        }
    }
}
