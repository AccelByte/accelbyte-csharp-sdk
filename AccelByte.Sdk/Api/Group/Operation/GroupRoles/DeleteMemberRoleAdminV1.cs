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
    /// deleteMemberRoleAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [DELETE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to delete member role. Any member role can't be deleted if the specific role is applied to the configuration (admin and member role)
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73207
    /// </summary>
    public class DeleteMemberRoleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMemberRoleAdminV1Builder Builder = new DeleteMemberRoleAdminV1Builder();

        public class DeleteMemberRoleAdminV1Builder
            : OperationBuilder<DeleteMemberRoleAdminV1Builder>
        {
            
            
            internal DeleteMemberRoleAdminV1Builder() { }






            public DeleteMemberRoleAdminV1 Build(
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRoleAdminV1 op = new DeleteMemberRoleAdminV1(this,
                    memberRoleId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteMemberRoleAdminV1(DeleteMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMemberRoleAdminV1(
            string memberRoleId,            
            string namespace_            
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}";

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