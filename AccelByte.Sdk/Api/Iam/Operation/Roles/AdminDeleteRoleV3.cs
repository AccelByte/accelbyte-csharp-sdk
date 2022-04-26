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
    /// AdminDeleteRoleV3
    ///
    /// Required permission ''ADMIN:ROLE [DELETE]''
    /// action code: 10403
    /// </summary>
    public class AdminDeleteRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRoleV3Builder Builder = new AdminDeleteRoleV3Builder();

        public class AdminDeleteRoleV3Builder
            : OperationBuilder<AdminDeleteRoleV3Builder>
        {
            
            internal AdminDeleteRoleV3Builder() { }






            public AdminDeleteRoleV3 Build(
                string roleId
            )
            {
                AdminDeleteRoleV3 op = new AdminDeleteRoleV3(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteRoleV3(AdminDeleteRoleV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteRoleV3(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}