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
    /// AdminGetRolesV3
    ///
    /// Required permission 'ADMIN:ROLE [READ]'
    /// 
    /// 
    /// action code: 10414
    /// </summary>
    public class AdminGetRolesV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRolesV3Builder Builder = new AdminGetRolesV3Builder();

        public class AdminGetRolesV3Builder
            : OperationBuilder<AdminGetRolesV3Builder>
        {
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public bool? IsWildcard { get; set; }
            
            public long? Limit { get; set; }
            
            internal AdminGetRolesV3Builder() { }


            public AdminGetRolesV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetRolesV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetRolesV3Builder SetIsWildcard(bool _isWildcard)
            {
                IsWildcard = _isWildcard;
                return this;
            }

            public AdminGetRolesV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public AdminGetRolesV3 Build(
            )
            {
                AdminGetRolesV3 op = new AdminGetRolesV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetRolesV3(AdminGetRolesV3Builder builder
        )
        {
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.IsWildcard != null) QueryParams["isWildcard"] = Convert.ToString(builder.IsWildcard)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRolesV3(
            string? after,            
            string? before,            
            bool? isWildcard,            
            long? limit            
        )
        {
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (isWildcard != null) QueryParams["isWildcard"] = Convert.ToString(isWildcard)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelRoleResponseWithManagersAndPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseWithManagersAndPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseWithManagersAndPaginationV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}