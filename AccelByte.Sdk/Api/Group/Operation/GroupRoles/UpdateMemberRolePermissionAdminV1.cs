// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// updateMemberRolePermissionAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update member role permission. It will replace the existing permission based on the request from this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73205
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// memberRolePermissions example value :
    /// 
    /// 
    /// 
    /// 
    /// "action": 2
    /// 
    /// 
    /// 
    /// 
    /// "resourceName": "GROUP:ROLE"
    /// 
    /// 
    /// 
    /// 
    /// The changes will update user role to be able to read a role of other member
    /// </summary>
    public class UpdateMemberRolePermissionAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMemberRolePermissionAdminV1Builder Builder = new UpdateMemberRolePermissionAdminV1Builder();

        public class UpdateMemberRolePermissionAdminV1Builder
            : OperationBuilder<UpdateMemberRolePermissionAdminV1Builder>
        {
            
            
            
            internal UpdateMemberRolePermissionAdminV1Builder() { }






            public UpdateMemberRolePermissionAdminV1 Build(
                ModelsUpdateMemberRolePermissionsRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePermissionAdminV1 op = new UpdateMemberRolePermissionAdminV1(this,
                    body,                    
                    memberRoleId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateMemberRolePermissionAdminV1(UpdateMemberRolePermissionAdminV1Builder builder,
            ModelsUpdateMemberRolePermissionsRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateMemberRolePermissionAdminV1(
            string memberRoleId,            
            string namespace_,            
            Model.ModelsUpdateMemberRolePermissionsRequestV1 body            
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}/permissions";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsUpdateMemberRoleResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateMemberRoleResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateMemberRoleResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}