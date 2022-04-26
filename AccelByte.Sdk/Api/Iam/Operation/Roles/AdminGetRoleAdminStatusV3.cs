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
    /// AdminGetRoleAdminStatusV3
    ///
    /// 
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
    /// action code: 10420
    /// </summary>
    public class AdminGetRoleAdminStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleAdminStatusV3Builder Builder = new AdminGetRoleAdminStatusV3Builder();

        public class AdminGetRoleAdminStatusV3Builder
            : OperationBuilder<AdminGetRoleAdminStatusV3Builder>
        {
            
            internal AdminGetRoleAdminStatusV3Builder() { }






            public AdminGetRoleAdminStatusV3 Build(
                string roleId
            )
            {
                AdminGetRoleAdminStatusV3 op = new AdminGetRoleAdminStatusV3(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetRoleAdminStatusV3(AdminGetRoleAdminStatusV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRoleAdminStatusV3(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/admin";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelRoleAdminStatusResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleAdminStatusResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleAdminStatusResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}