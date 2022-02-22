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
    /// AdminGetRoleManagersV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:ROLE [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// 
    /// 
    /// action code: 10415
    /// </summary>
    public class AdminGetRoleManagersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleManagersV3Builder Builder = new AdminGetRoleManagersV3Builder();

        public class AdminGetRoleManagersV3Builder
        {
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal AdminGetRoleManagersV3Builder() { }


            public AdminGetRoleManagersV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetRoleManagersV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetRoleManagersV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public AdminGetRoleManagersV3 Build(
                string roleId
            )
            {
                return new AdminGetRoleManagersV3(this,
                    roleId                    
                );
            }
        }

        private AdminGetRoleManagersV3(AdminGetRoleManagersV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            
        }
        #endregion

        public AdminGetRoleManagersV3(
            string roleId,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["roleId"] = roleId;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/managers";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelRoleManagersResponsesV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleManagersResponsesV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleManagersResponsesV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}