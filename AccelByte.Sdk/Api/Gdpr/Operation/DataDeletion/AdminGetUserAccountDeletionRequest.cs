// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetUserAccountDeletionRequest
    ///
    /// Retrieve specific user's account deletion request
    /// Scope: account
    /// </summary>
    public class AdminGetUserAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserAccountDeletionRequestBuilder Builder { get => new AdminGetUserAccountDeletionRequestBuilder(); }

        public class AdminGetUserAccountDeletionRequestBuilder
            : OperationBuilder<AdminGetUserAccountDeletionRequestBuilder>
        {





            internal AdminGetUserAccountDeletionRequestBuilder() { }






            public AdminGetUserAccountDeletionRequest Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserAccountDeletionRequest op = new AdminGetUserAccountDeletionRequest(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetUserAccountDeletionRequest(AdminGetUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserAccountDeletionRequest(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsDeletionData? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsDeletionData>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsDeletionData>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeletionData>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}