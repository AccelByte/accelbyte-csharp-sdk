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
    /// AdminRemoveRoleManagersV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:ROLE [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// 
    /// action code: 10409
    /// </summary>
    public class AdminRemoveRoleManagersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRemoveRoleManagersV3Builder Builder = new AdminRemoveRoleManagersV3Builder();

        public class AdminRemoveRoleManagersV3Builder
            : OperationBuilder<AdminRemoveRoleManagersV3Builder>
        {
            
            
            internal AdminRemoveRoleManagersV3Builder() { }






            public AdminRemoveRoleManagersV3 Build(
                ModelRoleManagersRequestV3 body,
                string roleId
            )
            {
                AdminRemoveRoleManagersV3 op = new AdminRemoveRoleManagersV3(this,
                    body,                    
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminRemoveRoleManagersV3(AdminRemoveRoleManagersV3Builder builder,
            ModelRoleManagersRequestV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRemoveRoleManagersV3(
            string roleId,            
            Model.ModelRoleManagersRequestV3 body            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/managers";

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