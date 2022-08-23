// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    internal class Program
    {
        static int Main(string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);

            var host = new WebHostBuilder()
                .UseKestrel((opt) =>
                {
                    opt.AllowSynchronousIO = true;
                })
                .UseSetting(WebHostDefaults.SuppressStatusMessagesKey, "True")
                .UseUrls("http://0.0.0.0:9090")
                .ConfigureServices((s) =>
                {
                    s.AddScoped<IAccelByteSdkProvider>(sp => new DefaultAccelByteSdkProvider(cArgs));
                    s.AddSingleton<ICacheProvider>(sp => new LocalCacheProvider());
                })
                .UseStartup<SampleWebStartup>()
                .Build();

            host.RunAsync();
            Console.WriteLine("TitleMatchmaking Sample API Local Server is ready.");
            Console.WriteLine("Press enter to close server...");
            Console.ReadLine();
            host.StopAsync();

            return 0;
        }
    }
}