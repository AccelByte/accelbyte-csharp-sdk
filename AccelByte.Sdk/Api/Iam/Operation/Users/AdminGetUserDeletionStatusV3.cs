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
    /// AdminGetUserDeletionStatusV3
    ///
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:DELETIONSTATUS:USER:{userId} [READ]'
    /// action code : 10145
    /// </summary>
    public class AdminGetUserDeletionStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserDeletionStatusV3Builder Builder { get => new AdminGetUserDeletionStatusV3Builder(); }

        public class AdminGetUserDeletionStatusV3Builder
            : OperationBuilder<AdminGetUserDeletionStatusV3Builder>
        {





            internal AdminGetUserDeletionStatusV3Builder() { }






            public AdminGetUserDeletionStatusV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserDeletionStatusV3 op = new AdminGetUserDeletionStatusV3(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetUserDeletionStatusV3(AdminGetUserDeletionStatusV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public AdminGetUserDeletionStatusV3(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/deletion/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public Model.ModelUserDeletionStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUserDeletionStatusResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUserDeletionStatusResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserDeletionStatusResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}