// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Reflection;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

namespace AccelByte.Sdk.Sample.Cli
{
    internal class Program
    {
        static int Main(string[] args)
        {
            try
            {
                CommandArguments cArgs = new CommandArguments(args);
                CommandFactory cFactory = new CommandFactory(
                    "AccelByte.Sdk.Sample.Cli.ApiCommand",
                    Assembly.GetExecutingAssembly());

                if (cArgs.IsWebService)
                {
                    if (cArgs.ServiceName == String.Empty)
                        throw new Exception("Unspecified service name for websocket service.");

                    AccelByteSDK sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                    WebSocketCommand wsCmd = new WebSocketCommand(sdk.Configuration);
                    if (cArgs.IsWebServiceListenMode)
                        wsCmd.Listen(cArgs.ServiceName);
                    else
                    {
                        string response = wsCmd.Execute(cArgs.ServiceName, cArgs.WebServicePayload);
                        Console.Write("Response:\n{0}", response);
                    }                    
                }
                else if (cArgs.OperationName == "")
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
                        string response = cmd.Run();
                        Console.WriteLine("Response:\n{0}", response);
                    }                    
                } 

		        return 0;               
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: {0}", ex.Message);
		        return 2;
            }
        }
    }
}