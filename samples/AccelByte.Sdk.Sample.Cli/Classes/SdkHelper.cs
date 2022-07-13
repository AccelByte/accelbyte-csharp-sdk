// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Sample.Cli
{
    public class SdkHelper
    {
        public static AccelByteSDK CreateSdkAndLogin(CommandArguments cArgs)
        {
            IConfigRepository cRepo = ConfigRepository.Default;
            IHttpClient httpClient = HttpClient.Default;
            ITokenRepository tokenRepo = new FileBasedTokenRepository();

            if (cArgs.IsLogEnabled)
            {
                IHttpLogger dLogger = new DefaultHttpLogger();
                httpClient.SetLogger(dLogger);                
            }
            
            AccelByteConfig config = new AccelByteConfig(httpClient, tokenRepo, cRepo);
            AccelByteSDK sdk = new AccelByteSDK(config);

            if (!tokenRepo.HasToken)
            {
                Console.WriteLine("No stored token found. Trying to login using supplied credential if any.");
                if (cArgs.LoginType == CommandArguments.LoginTypeUser)
                {
                    if ((cArgs.LoginUsername == String.Empty) || (cArgs.LoginPassword == String.Empty))
                        throw new Exception("Username and/or password cannot be null for login type user.");
                    if (!sdk.LoginUser(cArgs.LoginUsername, cArgs.LoginPassword))
                        throw new Exception("Login for '" + cArgs.LoginUsername + "' has failed!");
                }
                else if (cArgs.LoginType == CommandArguments.LoginTypeClient)
                {
                    if (!sdk.LoginClient())
                        throw new Exception("Client login failed!");
                }
                else
                    throw new Exception("Invalid login type.");
            }

            return sdk;
        }

        public static AccelByteSDK CreatyEmptySdk()
        {
            IConfigRepository cRepo = ConfigRepository.Default;
            IHttpClient httpClient = HttpClient.Default;
            ITokenRepository tokenRepo = new FileBasedTokenRepository();

            AccelByteConfig config = new AccelByteConfig(httpClient, tokenRepo, cRepo);
            AccelByteSDK sdk = new AccelByteSDK(config);

            return sdk;
        }

        public static string SerializeToJson(object modelObj)
        {
            return JsonSerializer.Serialize(modelObj, modelObj.GetType(), new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }
    }
}
