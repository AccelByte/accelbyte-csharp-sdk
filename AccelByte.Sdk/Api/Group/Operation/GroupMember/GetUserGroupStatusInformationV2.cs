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
    /// GetUserGroupStatusInformationV2
    ///
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP [READ]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to get user group status information.
    /// 
    /// 
    /// 
    /// 
    /// get user group status information. This endpoint will check the member and group information, and also the role permission of the the user who accesses this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73409
    /// </summary>
    public class GetUserGroupStatusInformationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserGroupStatusInformationV2Builder Builder { get => new GetUserGroupStatusInformationV2Builder(); }

        public class GetUserGroupStatusInformationV2Builder
            : OperationBuilder<GetUserGroupStatusInformationV2Builder>
        {





            internal GetUserGroupStatusInformationV2Builder() { }






            public GetUserGroupStatusInformationV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                GetUserGroupStatusInformationV2 op = new GetUserGroupStatusInformationV2(this,
                    groupId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserGroupStatusInformationV2(GetUserGroupStatusInformationV2Builder builder,
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

        public GetUserGroupStatusInformationV2(
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

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetUserGroupInformationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}