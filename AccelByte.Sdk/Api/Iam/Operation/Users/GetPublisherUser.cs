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
    /// GetPublisherUser
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/{userId}/publisher [GET]_**
    /// 
    /// **Restriction:**
    /// Path Parameter *namespace* can be provided only with game namespace
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetPublisherUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublisherUserBuilder Builder { get => new GetPublisherUserBuilder(); }

        public class GetPublisherUserBuilder
            : OperationBuilder<GetPublisherUserBuilder>
        {





            internal GetPublisherUserBuilder() { }






            public GetPublisherUser Build(
                string namespace_,
                string userId
            )
            {
                GetPublisherUser op = new GetPublisherUser(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetPublisherUser(GetPublisherUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPublisherUser(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/publisher";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelGetPublisherUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelGetPublisherUserResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelGetPublisherUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetPublisherUserResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}