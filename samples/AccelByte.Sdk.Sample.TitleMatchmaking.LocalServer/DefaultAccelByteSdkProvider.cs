using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class DefaultAccelByteSdkProvider : IAccelByteSdkProvider
    {
        public AccelByteSDK Sdk { get; private set; }

        public DefaultAccelByteSdkProvider(CommandArguments cArgs)
        {
            HttpClientPolicy policy = HttpClientPolicy.Default;
            policy.MaxRetryCount = 1000;
            policy.RetryInterval = 1000;

            //retry logic for claim server if server is not ready
            policy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");

            AccelByteSdkBuilder builder = AccelByteSDK.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(policy)
                    .Build())
                .UseDefaultTokenRepository();
            if (cArgs.SdkConfigFile != String.Empty)
                builder.UseJsonConfigRepository(cArgs.SdkConfigFile);
            else
                builder.UseDefaultConfigRepository();
            if (cArgs.IsLogEnabled)
                builder.EnableLog();

            Sdk = builder.Build();
        }
    }
}