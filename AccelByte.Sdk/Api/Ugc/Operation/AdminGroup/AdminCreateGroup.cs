// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminCreateGroup
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENTGROUP [CREATE]
    /// </summary>
    public class AdminCreateGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateGroupBuilder Builder = new AdminCreateGroupBuilder();

        public class AdminCreateGroupBuilder
        {
            
            
            internal AdminCreateGroupBuilder() { }





            public AdminCreateGroup Build(
                ModelsCreateGroupRequest body,
                string namespace_
            )
            {
                return new AdminCreateGroup(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private AdminCreateGroup(AdminCreateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminCreateGroup(
            string namespace_,            
            Model.ModelsCreateGroupRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateGroupResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}