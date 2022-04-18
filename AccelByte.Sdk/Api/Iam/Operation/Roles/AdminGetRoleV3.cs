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
    /// AdminGetRoleV3
    ///
    /// Required permission 'ADMIN:ROLE [READ]'
    /// 
    /// 
    /// action code: 10419
    /// </summary>
    public class AdminGetRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleV3Builder Builder = new AdminGetRoleV3Builder();

        public class AdminGetRoleV3Builder
            : OperationBuilder<AdminGetRoleV3Builder>
        {
            
            internal AdminGetRoleV3Builder() { }





            public AdminGetRoleV3 Build(
                string roleId
            )
            {
                AdminGetRoleV3 op = new AdminGetRoleV3(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetRoleV3(AdminGetRoleV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRoleV3(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelRoleResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}