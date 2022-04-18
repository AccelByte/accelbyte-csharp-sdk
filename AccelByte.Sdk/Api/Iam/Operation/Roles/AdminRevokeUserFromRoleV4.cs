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
    /// AdminRevokeUserFromRoleV4
    ///
    /// Required permission ADMIN:ROLE [UPDATE]
    /// 
    /// Current implementation will revoke user from role in all assigned namespaces.
    /// 
    /// Parameters:
    /// - userId: string (required)
    /// - namespace: string (userâs namespace) (required)
    /// 
    /// action code: 10411
    /// </summary>
    public class AdminRevokeUserFromRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRevokeUserFromRoleV4Builder Builder = new AdminRevokeUserFromRoleV4Builder();

        public class AdminRevokeUserFromRoleV4Builder
            : OperationBuilder<AdminRevokeUserFromRoleV4Builder>
        {
            
            
            internal AdminRevokeUserFromRoleV4Builder() { }





            public AdminRevokeUserFromRoleV4 Build(
                ModelRevokeUserV4Request body,
                string roleId
            )
            {
                AdminRevokeUserFromRoleV4 op = new AdminRevokeUserFromRoleV4(this,
                    body,                    
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminRevokeUserFromRoleV4(AdminRevokeUserFromRoleV4Builder builder,
            ModelRevokeUserV4Request body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRevokeUserFromRoleV4(
            string roleId,            
            Model.ModelRevokeUserV4Request body            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

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