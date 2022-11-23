using System;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Sample.GettingStarted
{
    internal class Program
    {
        static int Main(string[] args)
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .Build();

            bool login = sdk.LoginUser();
            if (!login)
            {
                Console.WriteLine("Login failed");
                return 1;
            }

            try
            {
                List<RetrieveAcceptedAgreementResponse>? response = sdk.Legal.Agreement.RetrieveAgreementsPublicOp.Execute();
                if (response == null)
                    throw new Exception("Response is null");

                foreach (var aggreement in response)
                    Console.WriteLine(aggreement.PolicyName);
            }
            catch (HttpResponseException e)
            {
                Console.WriteLine(e.Message);
                return 2;
            }

            bool logout = sdk.Logout();
            if (!logout)
            {
                Console.WriteLine("Logout failed");
                return 1;
            }

            return 0;
        }
    }
}