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
    /// createMemberRoleAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [CREATE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to create new member role
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73202
    /// </summary>
    public class CreateMemberRoleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateMemberRoleAdminV1Builder Builder = new CreateMemberRoleAdminV1Builder();

        public class CreateMemberRoleAdminV1Builder
        {
            
            
            internal CreateMemberRoleAdminV1Builder() { }





            public CreateMemberRoleAdminV1 Build(
                ModelsCreateMemberRoleRequestV1 body,
                string namespace_
            )
            {
                return new CreateMemberRoleAdminV1(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private CreateMemberRoleAdminV1(CreateMemberRoleAdminV1Builder builder,
            ModelsCreateMemberRoleRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public CreateMemberRoleAdminV1(
            string namespace_,            
            Model.ModelsCreateMemberRoleRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateMemberRoleResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateMemberRoleResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateMemberRoleResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}