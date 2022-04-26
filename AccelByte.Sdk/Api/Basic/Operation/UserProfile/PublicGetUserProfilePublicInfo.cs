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
    /// publicGetUserProfilePublicInfo
    ///
    /// Get user profile public info.
    /// Other detail info:
    /// 
    ///   * Action code : 11404
    ///   *  Returns : user public profile
    /// </summary>
    public class PublicGetUserProfilePublicInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserProfilePublicInfoBuilder Builder = new PublicGetUserProfilePublicInfoBuilder();

        public class PublicGetUserProfilePublicInfoBuilder
            : OperationBuilder<PublicGetUserProfilePublicInfoBuilder>
        {
            
            
            internal PublicGetUserProfilePublicInfoBuilder() { }






            public PublicGetUserProfilePublicInfo Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserProfilePublicInfo op = new PublicGetUserProfilePublicInfo(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUserProfilePublicInfo(PublicGetUserProfilePublicInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

        }
        #endregion

        public PublicGetUserProfilePublicInfo(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/public";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.UserProfilePublicInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePublicInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePublicInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}