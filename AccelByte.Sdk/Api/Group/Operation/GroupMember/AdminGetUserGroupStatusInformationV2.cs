// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// AdminGetUserGroupStatusInformationV2
    ///
    /// This endpoint is used to get user group status information.
    /// </summary>
    public class AdminGetUserGroupStatusInformationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserGroupStatusInformationV2Builder Builder { get => new AdminGetUserGroupStatusInformationV2Builder(); }

        public class AdminGetUserGroupStatusInformationV2Builder
            : OperationBuilder<AdminGetUserGroupStatusInformationV2Builder>
        {





            internal AdminGetUserGroupStatusInformationV2Builder() { }






            public AdminGetUserGroupStatusInformationV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                AdminGetUserGroupStatusInformationV2 op = new AdminGetUserGroupStatusInformationV2(this,
                    groupId,
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

        private AdminGetUserGroupStatusInformationV2(AdminGetUserGroupStatusInformationV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserGroupStatusInformationV2(
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetUserGroupInformationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}