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
    /// PublicListUserIDByPlatformUserIDsV3
    ///
    /// List User ID By Platform User ID
    /// This endpoint intended to list game user ID from the given namespace
    /// This endpoint return list of user ID by given platform ID and list of platform user ID
    /// 
    /// nintendo platform user ID : NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// </summary>
    public class PublicListUserIDByPlatformUserIDsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserIDByPlatformUserIDsV3Builder Builder = new PublicListUserIDByPlatformUserIDsV3Builder();

        public class PublicListUserIDByPlatformUserIDsV3Builder
        {
            
            
            
            internal PublicListUserIDByPlatformUserIDsV3Builder() { }





            public PublicListUserIDByPlatformUserIDsV3 Build(
                ModelPlatformUserIDRequest body,
                string namespace_,
                string platformId
            )
            {
                return new PublicListUserIDByPlatformUserIDsV3(this,
                    body,                    
                    namespace_,                    
                    platformId                    
                );
            }
        }

        private PublicListUserIDByPlatformUserIDsV3(PublicListUserIDByPlatformUserIDsV3Builder builder,
            ModelPlatformUserIDRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicListUserIDByPlatformUserIDsV3(
            string namespace_,            
            string platformId,            
            Model.ModelPlatformUserIDRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonUserPlatforms? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}