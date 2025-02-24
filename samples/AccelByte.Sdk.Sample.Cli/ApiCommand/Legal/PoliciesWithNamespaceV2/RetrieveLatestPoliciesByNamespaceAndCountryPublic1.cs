// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal", "retrievelatestpoliciesbynamespaceandcountrypublic1")]
    public class RetrieveLatestPoliciesByNamespaceAndCountryPublic1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "RetrieveLatestPoliciesByNamespaceAndCountryPublic1"; } }

        [SdkCommandArgument("countryCode")]
        public string CountryCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        public RetrieveLatestPoliciesByNamespaceAndCountryPublic1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PoliciesWithNamespaceV2 wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PoliciesWithNamespaceV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveLatestPoliciesByNamespaceAndCountryPublic1.Builder;





            RetrieveLatestPoliciesByNamespaceAndCountryPublic1 operation = opBuilder.Build(
                CountryCode,
                Namespace,
                ClientId
            );


            List<AccelByte.Sdk.Api.Legal.Model.RetrieveSimplePolicyPublicResponseV2>? response = wrapper.RetrieveLatestPoliciesByNamespaceAndCountryPublic1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}