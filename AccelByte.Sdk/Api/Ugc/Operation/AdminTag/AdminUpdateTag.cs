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
    /// AdminUpdateTag
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:UGCCONFIG [UPDATE]
    /// updates a tag
    /// </summary>
    public class AdminUpdateTag : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateTagBuilder Builder = new AdminUpdateTagBuilder();

        public class AdminUpdateTagBuilder
        {
            
            
            
            internal AdminUpdateTagBuilder() { }





            public AdminUpdateTag Build(
                ModelsCreateTagRequest body,
                string namespace_,
                string tagId
            )
            {
                return new AdminUpdateTag(this,
                    body,                    
                    namespace_,                    
                    tagId                    
                );
            }
        }

        private AdminUpdateTag(AdminUpdateTagBuilder builder,
            ModelsCreateTagRequest body,
            string namespace_,
            string tagId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tagId"] = tagId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdateTag(
            string namespace_,            
            string tagId,            
            Model.ModelsCreateTagRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tagId"] = tagId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/tags/{tagId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateTagResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateTagResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateTagResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}