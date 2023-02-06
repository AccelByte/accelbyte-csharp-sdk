// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetRoleMembersV3
    ///
    /// Required permission 'ADMIN:ROLE [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Admin roles has its members listed in the role.
    /// 
    /// 
    /// 
    /// 
    /// action code: 10416
    /// </summary>
    public class AdminGetRoleMembersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleMembersV3Builder Builder { get => new AdminGetRoleMembersV3Builder(); }

        public class AdminGetRoleMembersV3Builder
            : OperationBuilder<AdminGetRoleMembersV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }





            internal AdminGetRoleMembersV3Builder() { }


            public AdminGetRoleMembersV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetRoleMembersV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetRoleMembersV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public AdminGetRoleMembersV3 Build(
                string roleId
            )
            {
                AdminGetRoleMembersV3 op = new AdminGetRoleMembersV3(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetRoleMembersV3(AdminGetRoleMembersV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRoleMembersV3(
            string roleId,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["roleId"] = roleId;
            
            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/members";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelRoleMembersResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleMembersResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleMembersResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}