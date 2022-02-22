// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetAdminUsersByRoleIdV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint search admin users which have the roleId
    /// 
    /// 
    /// 
    /// 
    /// Notes : this endpoint only accept admin role. Admin Role is role which have admin status and members.
    /// Use endpoint [GET] /roles/{roleId}/admin to check the role status
    /// 
    /// 
    /// 
    /// action code : 10140
    /// </summary>
    public class GetAdminUsersByRoleIdV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAdminUsersByRoleIdV3Builder Builder = new GetAdminUsersByRoleIdV3Builder();

        public class GetAdminUsersByRoleIdV3Builder
        {
            
            
            public long? After { get; set; }
            
            public long? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal GetAdminUsersByRoleIdV3Builder() { }


            public GetAdminUsersByRoleIdV3Builder SetAfter(long _after)
            {
                After = _after;
                return this;
            }

            public GetAdminUsersByRoleIdV3Builder SetBefore(long _before)
            {
                Before = _before;
                return this;
            }

            public GetAdminUsersByRoleIdV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public GetAdminUsersByRoleIdV3 Build(
                string namespace_,
                string roleId
            )
            {
                return new GetAdminUsersByRoleIdV3(this,
                    namespace_,                    
                    roleId                    
                );
            }
        }

        private GetAdminUsersByRoleIdV3(GetAdminUsersByRoleIdV3Builder builder,
            string namespace_,
            string roleId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            
            if (builder.After != null) QueryParams["after"] = Convert.ToString(builder.After)!;
            if (builder.Before != null) QueryParams["before"] = Convert.ToString(builder.Before)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            
        }
        #endregion

        public GetAdminUsersByRoleIdV3(
            string namespace_,            
            string roleId,            
            long? after,            
            long? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            
            if (after != null) QueryParams["after"] = Convert.ToString(after)!;
            if (before != null) QueryParams["before"] = Convert.ToString(before)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetUsersResponseWithPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUsersResponseWithPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUsersResponseWithPaginationV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}