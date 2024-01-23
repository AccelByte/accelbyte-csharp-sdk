// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccelByte.Sdk.Core.Pipeline
{
    public class SdkMandatoryOperationProcess : IOperationProcessPipeline
    {
        public IOperationProcessPipeline? Next { get; set; } = null;

        public Operation Handle(Operation operation, AccelByteSDK sdk)
        {
            AccelByteConfig config = sdk.Configuration;

            string selectedSecurity = Operation.SECURITY_BASIC;
            if (operation.PreferredSecurityMethod != String.Empty)
                selectedSecurity = operation.PreferredSecurityMethod;
            else
            {
                if (operation.Securities.Count > 0)
                    selectedSecurity = operation.Securities[0];
            }

            switch (selectedSecurity)
            {
                case Operation.SECURITY_BEARER:
                    if (!string.IsNullOrEmpty(config.TokenRepository.Token))
                    {
                        operation.HeaderParams["Authorization"] = $"{Operation.SECURITY_BEARER} {config.TokenRepository.Token}";
                    }
                    break;
                case Operation.SECURITY_BASIC:
                    var basicAuth = $"{config.ConfigRepository.ClientId}:{config.ConfigRepository.ClientSecret}";
                    var basicAuthBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(basicAuth));
                    operation.HeaderParams["Authorization"] = $"{Operation.SECURITY_BASIC} {basicAuthBase64}";
                    break;
                case Operation.SECURITY_COOKIE:
                    if (!string.IsNullOrEmpty(config.TokenRepository.Token))
                    {
                        operation.Cookies["access_token"] = config.TokenRepository.Token;
                    }
                    break;
            }

            if (config.ConfigRepository.EnableUserAgentInfo)
            {
                Version asVer = this.GetType().Assembly.GetName().Version!;
                string userAgent = String.Format("AccelByteCSharpSDK/{0}.{1}.{2} ({3})", asVer.Major, asVer.Minor, asVer.Revision, config.ConfigRepository.AppName);
                operation.HeaderParams["User-Agent"] = userAgent;
            }

            if (config.ConfigRepository.EnableTraceId)
            {
                string uTime = DateTimeOffset.Now.ToUnixTimeSeconds().ToString("X").PadLeft(8, '0').ToLowerInvariant();
                string rGuid = Guid.NewGuid().ToString().Replace("-", "");
                string guid = String.Empty;
                for (int i = 0; i < rGuid.Length; i += 4)
                    guid += rGuid.Substring(i, 3);

                string amazonTraceId = String.Format("{0}-{1}-{2}", config.ConfigRepository.TraceIdVersion, uTime, guid);
                operation.HeaderParams["X-Amzn-Trace-Id"] = amazonTraceId;
            }

            string xFlightId = operation.FlightId;
            if (xFlightId == "")
                xFlightId = sdk.FlightId;
            operation.HeaderParams["x-flight-id"] = xFlightId;

            return operation;
        }
    }
}