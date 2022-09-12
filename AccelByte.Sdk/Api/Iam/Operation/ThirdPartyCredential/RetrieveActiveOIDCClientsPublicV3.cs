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
    /// RetrieveActiveOIDCClientsPublicV3
    ///
    /// This is the Public API to Get All Active OIDC Platform Credential By Client ID
    /// </summary>
    public class RetrieveActiveOIDCClientsPublicV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveActiveOIDCClientsPublicV3Builder Builder = new RetrieveActiveOIDCClientsPublicV3Builder();

        public class RetrieveActiveOIDCClientsPublicV3Builder
            : OperationBuilder<RetrieveActiveOIDCClientsPublicV3Builder>
        {





            internal RetrieveActiveOIDCClientsPublicV3Builder() { }






            public RetrieveActiveOIDCClientsPublicV3 Build(
                string namespace_,
                string clientId
            )
            {
                RetrieveActiveOIDCClientsPublicV3 op = new RetrieveActiveOIDCClientsPublicV3(this,
                    namespace_,
                    clientId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveActiveOIDCClientsPublicV3(RetrieveActiveOIDCClientsPublicV3Builder builder,
            string namespace_,
            string clientId
        )
        {
            PathParams["namespace"] = namespace_;

            if (clientId is not null) QueryParams["clientId"] = clientId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveActiveOIDCClientsPublicV3(
            string namespace_,
            string clientId
        )
        {
            PathParams["namespace"] = namespace_;

            if (clientId is not null) QueryParams["clientId"] = clientId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/clients/oidc";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelPublicThirdPartyPlatformInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}