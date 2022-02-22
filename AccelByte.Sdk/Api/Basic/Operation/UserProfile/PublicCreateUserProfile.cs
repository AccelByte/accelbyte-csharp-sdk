// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicCreateUserProfile
    ///
    /// Create user profile.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=1 (CREATE)
    ///   *  Action code : 11401
    ///   *  Language : allowed format: en, en-US
    ///   *  Timezone : IANA time zone, e.g. Asia/Shanghai
    ///   *  Returns : Created user profile
    /// </summary>
    public class PublicCreateUserProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserProfileBuilder Builder = new PublicCreateUserProfileBuilder();

        public class PublicCreateUserProfileBuilder
        {
            
            
            public Model.UserProfileCreate? Body { get; set; }
            
            internal PublicCreateUserProfileBuilder() { }



            public PublicCreateUserProfileBuilder SetBody(Model.UserProfileCreate _body)
            {
                Body = _body;
                return this;
            }



            public PublicCreateUserProfile Build(
                string namespace_,
                string userId
            )
            {
                return new PublicCreateUserProfile(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicCreateUserProfile(PublicCreateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public PublicCreateUserProfile(
            string namespace_,            
            string userId,            
            Model.UserProfileCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfileInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfileInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}