// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicWebLinkPlatformEstablish
    ///
    /// This endpoint is used by third party to redirect the code for the purpose of linking the account third party to IAM account.
    /// </summary>
    public class PublicWebLinkPlatformEstablish : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicWebLinkPlatformEstablishBuilder Builder { get => new PublicWebLinkPlatformEstablishBuilder(); }

        public class PublicWebLinkPlatformEstablishBuilder
            : OperationBuilder<PublicWebLinkPlatformEstablishBuilder>
        {

            public string? Code { get; set; }





            internal PublicWebLinkPlatformEstablishBuilder() { }


            public PublicWebLinkPlatformEstablishBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }





            public PublicWebLinkPlatformEstablish Build(
                string namespace_,
                string platformId,
                string state
            )
            {
                PublicWebLinkPlatformEstablish op = new PublicWebLinkPlatformEstablish(this,
                    namespace_,
                    platformId,
                    state
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicWebLinkPlatformEstablish(PublicWebLinkPlatformEstablishBuilder builder,
            string namespace_,
            string platformId,
            string state
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;

            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (state is not null) QueryParams["state"] = state;





            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicWebLinkPlatformEstablish(
            string namespace_,
            string platformId,
            string? code,
            string state
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;

            if (code is not null) QueryParams["code"] = code;
            if (state is not null) QueryParams["state"] = state;





            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/web/link/establish";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var payloadString = Helper.ConvertInputStreamToString(payload);

            if (code == (HttpStatusCode)302)
            {
                return payloadString;
            }

            throw new HttpResponseException(code, payloadString);
        }
    }

}