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
    /// getMemberRolesListPublicV2
    ///
    /// 
    /// 
    /// This endpoint is used to get list of member roles
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73201
    /// </summary>
    public class GetMemberRolesListPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMemberRolesListPublicV2Builder Builder { get => new GetMemberRolesListPublicV2Builder(); }

        public class GetMemberRolesListPublicV2Builder
            : OperationBuilder<GetMemberRolesListPublicV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetMemberRolesListPublicV2Builder() { }


            public GetMemberRolesListPublicV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetMemberRolesListPublicV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetMemberRolesListPublicV2 Build(
                string namespace_
            )
            {
                GetMemberRolesListPublicV2 op = new GetMemberRolesListPublicV2(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetMemberRolesListPublicV2(GetMemberRolesListPublicV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetMemberRolesListPublicV2(
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

        public override string Path => "/group/v2/public/namespaces/{namespace}/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetMemberRolesListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetMemberRolesListResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetMemberRolesListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRolesListResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}