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
    /// AdminAssignUserToRoleV4
    ///
    /// Required permission ADMIN:ROLE [UPDATE]
    /// 
    /// Parameters:
    /// - userId: string (required)
    /// - namespace: string (userâs namespace) (required)
    /// - assignedNamespaces: array of string (namespaces to be assigned on role) (required)
    /// 
    /// action code: 10410
    /// </summary>
    public class AdminAssignUserToRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAssignUserToRoleV4Builder Builder = new AdminAssignUserToRoleV4Builder();

        public class AdminAssignUserToRoleV4Builder
            : OperationBuilder<AdminAssignUserToRoleV4Builder>
        {
            
            
            internal AdminAssignUserToRoleV4Builder() { }





            public AdminAssignUserToRoleV4 Build(
                ModelAssignUserV4Request body,
                string roleId
            )
            {
                AdminAssignUserToRoleV4 op = new AdminAssignUserToRoleV4(this,
                    body,                    
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminAssignUserToRoleV4(AdminAssignUserToRoleV4Builder builder,
            ModelAssignUserV4Request body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAssignUserToRoleV4(
            string roleId,            
            Model.ModelAssignUserV4Request body            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelAssignedUserV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelAssignedUserV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAssignedUserV4Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}