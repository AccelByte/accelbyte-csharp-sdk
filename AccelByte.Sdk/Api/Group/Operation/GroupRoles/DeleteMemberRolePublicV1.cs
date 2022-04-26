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
    /// deleteMemberRolePublicV1
    ///
    /// Required Member Role Permission: "GROUP:ROLE [UPDATE]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to remove role from group member
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73204
    /// </summary>
    public class DeleteMemberRolePublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMemberRolePublicV1Builder Builder = new DeleteMemberRolePublicV1Builder();

        public class DeleteMemberRolePublicV1Builder
            : OperationBuilder<DeleteMemberRolePublicV1Builder>
        {
            
            
            
            internal DeleteMemberRolePublicV1Builder() { }






            public DeleteMemberRolePublicV1 Build(
                ModelsRemoveRoleFromMemberRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRolePublicV1 op = new DeleteMemberRolePublicV1(this,
                    body,                    
                    memberRoleId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteMemberRolePublicV1(DeleteMemberRolePublicV1Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
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

        public DeleteMemberRolePublicV1(
            string memberRoleId,            
            string namespace_,            
            Model.ModelsRemoveRoleFromMemberRequestV1 body            
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/roles/{memberRoleId}/members";

        public override HttpMethod Method => HttpMethod.Delete;

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