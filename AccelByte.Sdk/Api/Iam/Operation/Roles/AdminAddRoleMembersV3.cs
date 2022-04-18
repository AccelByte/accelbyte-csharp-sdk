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
    /// AdminAddRoleMembersV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:ROLE [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// Admin roles has its members listed in the role.
    /// 
    /// 
    /// 
    /// 
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// 
    /// action code: 10410
    /// </summary>
    public class AdminAddRoleMembersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddRoleMembersV3Builder Builder = new AdminAddRoleMembersV3Builder();

        public class AdminAddRoleMembersV3Builder
            : OperationBuilder<AdminAddRoleMembersV3Builder>
        {
            
            
            internal AdminAddRoleMembersV3Builder() { }





            public AdminAddRoleMembersV3 Build(
                ModelRoleMembersRequestV3 body,
                string roleId
            )
            {
                AdminAddRoleMembersV3 op = new AdminAddRoleMembersV3(this,
                    body,                    
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminAddRoleMembersV3(AdminAddRoleMembersV3Builder builder,
            ModelRoleMembersRequestV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddRoleMembersV3(
            string roleId,            
            Model.ModelRoleMembersRequestV3 body            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/members";

        public override HttpMethod Method => HttpMethod.Post;

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