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
    /// getGroupListAdminV1
    ///
    /// Required Permission: "ADMIN:NAMESPACE:{namespace}:GROUP [READ]"
    /// 
    /// 
    /// 
    /// 
    /// Get list of groups. This endpoint will show any types of group
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73301
    /// </summary>
    public class GetGroupListAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupListAdminV1Builder Builder { get => new GetGroupListAdminV1Builder(); }

        public class GetGroupListAdminV1Builder
            : OperationBuilder<GetGroupListAdminV1Builder>
        {

            public string? ConfigurationCode { get; set; }

            public string? GroupName { get; set; }

            public string? GroupRegion { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetGroupListAdminV1Builder() { }


            public GetGroupListAdminV1Builder SetConfigurationCode(string _configurationCode)
            {
                ConfigurationCode = _configurationCode;
                return this;
            }

            public GetGroupListAdminV1Builder SetGroupName(string _groupName)
            {
                GroupName = _groupName;
                return this;
            }

            public GetGroupListAdminV1Builder SetGroupRegion(string _groupRegion)
            {
                GroupRegion = _groupRegion;
                return this;
            }

            public GetGroupListAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupListAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetGroupListAdminV1 Build(
                string namespace_
            )
            {
                GetGroupListAdminV1 op = new GetGroupListAdminV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetGroupListAdminV1(GetGroupListAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ConfigurationCode is not null) QueryParams["configurationCode"] = builder.ConfigurationCode;
            if (builder.GroupName is not null) QueryParams["groupName"] = builder.GroupName;
            if (builder.GroupRegion is not null) QueryParams["groupRegion"] = builder.GroupRegion;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGroupListAdminV1(
            string namespace_,
            string? configurationCode,
            string? groupName,
            string? groupRegion,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (configurationCode is not null) QueryParams["configurationCode"] = configurationCode;
            if (groupName is not null) QueryParams["groupName"] = groupName;
            if (groupRegion is not null) QueryParams["groupRegion"] = groupRegion;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetGroupsListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsListResponseV1>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}