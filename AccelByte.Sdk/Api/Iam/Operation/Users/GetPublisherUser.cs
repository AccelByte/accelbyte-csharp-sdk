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
    /// GetPublisherUser
    ///
    /// 
    /// 
    /// Required permissions 'NAMESPACE:{namespace}:PUBLISHER:USER:{userId} [READ].
    /// 
    /// 
    /// 
    /// 
    /// Restriction:
    /// Path Parameter namespace can be provided only with game namespace
    /// </summary>
    public class GetPublisherUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublisherUserBuilder Builder = new GetPublisherUserBuilder();

        public class GetPublisherUserBuilder
        {
            
            
            internal GetPublisherUserBuilder() { }





            public GetPublisherUser Build(
                string namespace_,
                string userId
            )
            {
                return new GetPublisherUser(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetPublisherUser(GetPublisherUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public GetPublisherUser(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/publisher";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetPublisherUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetPublisherUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetPublisherUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}