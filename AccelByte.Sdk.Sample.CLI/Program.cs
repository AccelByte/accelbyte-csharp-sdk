using System;
using System.Reflection;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

namespace AccelByte.Sdk.Sample.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AccelByte Sdk C# CLI App");
            try
            {
                CommandArguments cArgs = new CommandArguments(args);
                CommandFactory cFactory = new CommandFactory(
                    "AccelByte.Sdk.Sample.CLI.ApiCommand",
                    Assembly.GetExecutingAssembly());

                if (cArgs.OperationName == "login")
                {
                    AccelByteSDK sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                    Console.WriteLine("Login OK. Press enter to exit.");
                }
                else
                {
                    AccelByteSDK sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                    ISdkConsoleCommand cmd = cFactory.CreateCommandObject(cArgs, sdk);

                    Console.WriteLine("Running {0} :: {1}", cmd.ServiceName, cmd.OperationName);
                    string response = cmd.Run();
                    Console.WriteLine("Response:\n{0}", response);
                    Console.WriteLine("\nRun finished. Press enter to exit.");
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}