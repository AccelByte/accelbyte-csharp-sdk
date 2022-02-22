// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// getMemberRolesListAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [READ]
    /// 
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
    public class GetMemberRolesListAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMemberRolesListAdminV1Builder Builder = new GetMemberRolesListAdminV1Builder();

        public class GetMemberRolesListAdminV1Builder
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetMemberRolesListAdminV1Builder() { }


            public GetMemberRolesListAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetMemberRolesListAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetMemberRolesListAdminV1 Build(
                string namespace_
            )
            {
                return new GetMemberRolesListAdminV1(this,
                    namespace_                    
                );
            }
        }

        private GetMemberRolesListAdminV1(GetMemberRolesListAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public GetMemberRolesListAdminV1(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetMemberRolesListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRolesListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRolesListResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}