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
    /// getUserGroupInformationPublicV2
    ///
    /// Required valid user authentication
    /// 
    /// This endpoint is used to get user joined group information.
    /// 
    /// Get user group joined information. If user does not belong to any group, it will return warning to give information about it
    /// 
    /// Group Member Status:
    /// 
    /// * JOINED: status of user already joined to a group
    /// 
    /// Action Code: 73405
    /// </summary>
    public class GetUserGroupInformationPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserGroupInformationPublicV2Builder Builder { get => new GetUserGroupInformationPublicV2Builder(); }

        public class GetUserGroupInformationPublicV2Builder
            : OperationBuilder<GetUserGroupInformationPublicV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetUserGroupInformationPublicV2Builder() { }


            public GetUserGroupInformationPublicV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserGroupInformationPublicV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserGroupInformationPublicV2 Build(
                string namespace_
            )
            {
                GetUserGroupInformationPublicV2 op = new GetUserGroupInformationPublicV2(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetUserGroupInformationPublicV2(GetUserGroupInformationPublicV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserGroupInformationPublicV2(
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/me/groups";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetGroupMemberListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetGroupMemberListResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetGroupMemberListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupMemberListResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}