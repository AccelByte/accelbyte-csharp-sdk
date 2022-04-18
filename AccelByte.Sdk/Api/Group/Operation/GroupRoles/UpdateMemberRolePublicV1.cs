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
    /// updateMemberRolePublicV1
    ///
    /// Required Member Role Permission: "GROUP:ROLE [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to assign role to group member
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73204
    /// </summary>
    public class UpdateMemberRolePublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMemberRolePublicV1Builder Builder = new UpdateMemberRolePublicV1Builder();

        public class UpdateMemberRolePublicV1Builder
            : OperationBuilder<UpdateMemberRolePublicV1Builder>
        {
            
            
            
            internal UpdateMemberRolePublicV1Builder() { }





            public UpdateMemberRolePublicV1 Build(
                ModelsAssignRoleToMemberRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRolePublicV1 op = new UpdateMemberRolePublicV1(this,
                    body,                    
                    memberRoleId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateMemberRolePublicV1(UpdateMemberRolePublicV1Builder builder,
            ModelsAssignRoleToMemberRequestV1 body,
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

        public UpdateMemberRolePublicV1(
            string memberRoleId,            
            string namespace_,            
            Model.ModelsAssignRoleToMemberRequestV1 body            
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/roles/{memberRoleId}/members";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetUserGroupInformationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}