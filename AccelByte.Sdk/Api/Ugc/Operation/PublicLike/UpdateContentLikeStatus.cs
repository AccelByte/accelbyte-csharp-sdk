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
    /// UpdateContentLikeStatus
    ///
    /// Requires valid user token
    /// </summary>
    public class UpdateContentLikeStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateContentLikeStatusBuilder Builder = new UpdateContentLikeStatusBuilder();

        public class UpdateContentLikeStatusBuilder
        {
            
            
            
            internal UpdateContentLikeStatusBuilder() { }





            public UpdateContentLikeStatus Build(
                ModelsContentLikeRequest body,
                string contentId,
                string namespace_
            )
            {
                return new UpdateContentLikeStatus(this,
                    body,                    
                    contentId,                    
                    namespace_                    
                );
            }
        }

        private UpdateContentLikeStatus(UpdateContentLikeStatusBuilder builder,
            ModelsContentLikeRequest body,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateContentLikeStatus(
            string contentId,            
            string namespace_,            
            Model.ModelsContentLikeRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/like";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsContentLikeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentLikeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentLikeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}