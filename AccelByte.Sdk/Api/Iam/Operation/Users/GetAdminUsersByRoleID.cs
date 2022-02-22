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
    /// GetAdminUsersByRoleID
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
    /// </summary>
    public class GetAdminUsersByRoleID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAdminUsersByRoleIDBuilder Builder = new GetAdminUsersByRoleIDBuilder();

        public class GetAdminUsersByRoleIDBuilder
        {
            
            public long? After { get; set; }
            
            public long? Before { get; set; }
            
            public long? Limit { get; set; }
            
            public string? RoleId { get; set; }
            
            internal GetAdminUsersByRoleIDBuilder() { }


            public GetAdminUsersByRoleIDBuilder SetAfter(long _after)
            {
                After = _after;
                return this;
            }

            public GetAdminUsersByRoleIDBuilder SetBefore(long _before)
            {
                Before = _before;
                return this;
            }

            public GetAdminUsersByRoleIDBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetAdminUsersByRoleIDBuilder SetRoleId(string _roleId)
            {
                RoleId = _roleId;
                return this;
            }




            public GetAdminUsersByRoleID Build(
                string namespace_
            )
            {
                return new GetAdminUsersByRoleID(this,
                    namespace_                    
                );
            }
        }

        private GetAdminUsersByRoleID(GetAdminUsersByRoleIDBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.After != null) QueryParams["after"] = Convert.ToString(builder.After)!;
            if (builder.Before != null) QueryParams["before"] = Convert.ToString(builder.Before)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.RoleId != null) QueryParams["roleId"] = builder.RoleId;
            
            
            
            
        }
        #endregion

        public GetAdminUsersByRoleID(
            string namespace_,            
            long? after,            
            long? before,            
            long? limit,            
            string? roleId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = Convert.ToString(after)!;
            if (before != null) QueryParams["before"] = Convert.ToString(before)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (roleId != null) QueryParams["roleId"] = roleId;
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/admin";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetAdminUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAdminUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAdminUsersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}