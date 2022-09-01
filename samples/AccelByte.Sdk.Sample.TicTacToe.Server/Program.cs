// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

using AccelByte.Sdk.Sample.TicTacToe.Provider;
using AccelByte.Sdk.Sample.TicTacToe.Server.Web;
using AccelByte.Sdk.Sample.TicTacToe.Server.Util;

namespace AccelByte.Sdk.Sample.TicTacToe.Server
{
    internal class Program
    {
        static int Main(string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);
            string listenUrl = String.Format("http://0.0.0.0:{0}", cArgs.ListenPort);

            var host = new WebHostBuilder()
                .UseKestrel((opt) =>
                {
                    opt.AllowSynchronousIO = true;
                })
                .UseSetting(WebHostDefaults.SuppressStatusMessagesKey, "True")
                .UseUrls(listenUrl)
                .ConfigureServices((s) =>
                {
                    s.AddScoped<IAccelByteSdkProvider>(sp => new DefaultAccelByteSdkProvider(cArgs));
                    s.AddSingleton<ICacheProvider>(sp => new LocalCacheProvider());
                })
                .UseStartup<APIStartup>()
                .Build();

            host.RunAsync();
            Console.WriteLine("TicTacToe Sample Server is ready.");
            Console.WriteLine("Listening on {0}", listenUrl);
            Console.WriteLine("Press enter to close server...");
            Console.ReadLine();
            host.StopAsync();

            return 0;
        }
    }
}