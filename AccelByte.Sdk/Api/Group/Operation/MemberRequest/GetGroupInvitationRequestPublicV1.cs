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
    /// getGroupInvitationRequestPublicV1
    ///
    /// Required valid user authentication
    /// 
    /// This endpoint is used to Get Group Invitation Request List
    /// 
    /// Get Group Invitation Request List for the user calling this endpoint. It will check any group invitation for this user
    /// 
    /// Action Code: 73502
    /// </summary>
    public class GetGroupInvitationRequestPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupInvitationRequestPublicV1Builder Builder { get => new GetGroupInvitationRequestPublicV1Builder(); }

        public class GetGroupInvitationRequestPublicV1Builder
            : OperationBuilder<GetGroupInvitationRequestPublicV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetGroupInvitationRequestPublicV1Builder() { }


            public GetGroupInvitationRequestPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupInvitationRequestPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetGroupInvitationRequestPublicV1 Build(
                string namespace_
            )
            {
                GetGroupInvitationRequestPublicV1 op = new GetGroupInvitationRequestPublicV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetGroupInvitationRequestPublicV1(GetGroupInvitationRequestPublicV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGroupInvitationRequestPublicV1(
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

        public override string Path => "/group/v1/public/namespaces/{namespace}/users/me/invite/request";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetMemberRequestsListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}