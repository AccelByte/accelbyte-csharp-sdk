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
    /// RequestGameTokenCodeResponseV3
    ///
    /// 
    /// 
    /// This endpoint is being used to request the code to generate publisher user's game token.
    /// 
    /// It require a valid user token with publisher namespace.
    /// 
    /// Path namespace should be a game namespace.
    /// 
    /// Client ID should match the target namespace.
    /// It response a code and it can be consumed by /iam/v3/token/exchange
    /// </summary>
    public class RequestGameTokenCodeResponseV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestGameTokenCodeResponseV3Builder Builder { get => new RequestGameTokenCodeResponseV3Builder(); }

        public class RequestGameTokenCodeResponseV3Builder
            : OperationBuilder<RequestGameTokenCodeResponseV3Builder>
        {





            internal RequestGameTokenCodeResponseV3Builder() { }






            public RequestGameTokenCodeResponseV3 Build(
                string clientId,
                string namespace_
            )
            {
                RequestGameTokenCodeResponseV3 op = new RequestGameTokenCodeResponseV3(this,
                    clientId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RequestGameTokenCodeResponseV3(RequestGameTokenCodeResponseV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (clientId is not null) FormParams["client_id"] = clientId;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RequestGameTokenCodeResponseV3(
            string namespace_,
            string clientId
        )
        {
            PathParams["namespace"] = namespace_;


            if (clientId is not null) FormParams["client_id"] = clientId;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/namespace/{namespace}/token/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.OauthmodelGameTokenCodeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelGameTokenCodeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelGameTokenCodeResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}