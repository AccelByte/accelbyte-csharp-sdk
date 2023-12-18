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
    /// GetUserByPlatformUserID
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint(Public): _/iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId} [GET]_**
    /// - **Substitute endpoint(Admin): _/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId} [GET]_**
    /// - **Note:**
    /// 1. difference in V3 response, format difference: Pascal case => Camel case
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUserByPlatformUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserByPlatformUserIDBuilder Builder { get => new GetUserByPlatformUserIDBuilder(); }

        public class GetUserByPlatformUserIDBuilder
            : OperationBuilder<GetUserByPlatformUserIDBuilder>
        {





            internal GetUserByPlatformUserIDBuilder() { }






            public GetUserByPlatformUserID Build(
                string namespace_,
                string platformID,
                string platformUserID
            )
            {
                GetUserByPlatformUserID op = new GetUserByPlatformUserID(this,
                    namespace_,
                    platformID,
                    platformUserID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetUserByPlatformUserID(GetUserByPlatformUserIDBuilder builder,
            string namespace_,
            string platformID,
            string platformUserID
        )
        {
            PathParams["namespace"] = namespace_;

            if (platformID is not null) QueryParams["platformID"] = platformID;
            if (platformUserID is not null) QueryParams["platformUserID"] = platformUserID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserByPlatformUserID(
            string namespace_,
            string platformID,
            string platformUserID
        )
        {
            PathParams["namespace"] = namespace_;

            if (platformID is not null) QueryParams["platformID"] = platformID;
            if (platformUserID is not null) QueryParams["platformUserID"] = platformUserID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/byPlatformUserID";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelPublicUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}