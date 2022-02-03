using System;
using System.Reflection;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

namespace AccelByte.Sdk.Sample.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AccelByte Sdk C# Cli App");
            try
            {
                CommandArguments cArgs = new CommandArguments(args);
                CommandFactory cFactory = new CommandFactory(
                    "AccelByte.Sdk.Sample.Cli.ApiCommand",
                    Assembly.GetExecutingAssembly());

                if (cArgs.OperationName == "")
                {
                    if (cArgs.IsListAllAsked)
                    {
                        AccelByteSDK sdk = SdkHelper.CreatyEmptySdk();
                        cFactory.EchoAllOperations(sdk);
                    }
                    else if (cArgs.IsListAsked && (cArgs.ServiceName == String.Empty))
                    {
                        AccelByteSDK sdk = SdkHelper.CreatyEmptySdk();
                        cFactory.EchoAllServiceNames(sdk);
                    }
                    else if (cArgs.IsListAsked && (cArgs.ServiceName != String.Empty))
                    {
                        AccelByteSDK sdk = SdkHelper.CreatyEmptySdk();
                        cFactory.EchoAllOperationInService(sdk, cArgs.ServiceName);
                    }
                    else
                        cArgs.EchoUsage();
                }
                else if (cArgs.OperationName == "login")
                {
                    AccelByteSDK sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                    Console.WriteLine("Login OK. Press enter to exit.");
                }
                else
                {
                    AccelByteSDK sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                    ISdkConsoleCommand cmd = cFactory.CreateCommandObject(cArgs, sdk);
                    if (cArgs.IsHelpAsked)
                    {
                        cArgs.EchoUsage();
                        cFactory.EchoCommandParams(cmd);
                    }
                    else
                    {
                        Console.WriteLine("Running {0} :: {1}", cmd.ServiceName, cmd.OperationName);
                        string response = cmd.Run();
                        Console.WriteLine("Response:\n{0}", response);
                        Console.WriteLine("\nRun finished. Press enter to exit.");
                        Console.ReadLine();
                    }                    
                }                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}