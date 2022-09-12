// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using Microsoft.AspNetCore.Hosting;

namespace AccelByte.Sdk.Sample.OIDC.Web
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel((opt) =>
                {
                    opt.AllowSynchronousIO = true;
                })
                .UseSetting(WebHostDefaults.SuppressStatusMessagesKey, "True")
                .UseUrls("http://0.0.0.0:9090")
                .ConfigureServices((s) =>
                {

                })
                .UseStartup<SampleWebStartup>()
                .Build();

            host.RunAsync();
            Console.WriteLine("Open your browser and go to 'http://localhost:9090' to start.");
            Console.WriteLine("Press enter to close server...");
            Console.ReadLine();
            host.StopAsync();

            return 0;
        }
    }
}