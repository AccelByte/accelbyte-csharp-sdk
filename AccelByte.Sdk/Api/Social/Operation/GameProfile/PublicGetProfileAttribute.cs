// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicGetProfileAttribute
    ///
    /// Returns game profile attribute.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=2 (READ)
    ///         *  Returns : attribute info
    /// </summary>
    public class PublicGetProfileAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetProfileAttributeBuilder Builder = new PublicGetProfileAttributeBuilder();

        public class PublicGetProfileAttributeBuilder
        {
            
            
            
            
            internal PublicGetProfileAttributeBuilder() { }





            public PublicGetProfileAttribute Build(
                string attributeName,
                string namespace_,
                string profileId,
                string userId
            )
            {
                return new PublicGetProfileAttribute(this,
                    attributeName,                    
                    namespace_,                    
                    profileId,                    
                    userId                    
                );
            }
        }

        private PublicGetProfileAttribute(PublicGetProfileAttributeBuilder builder,
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["attributeName"] = attributeName;
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public PublicGetProfileAttribute(
            string attributeName,            
            string namespace_,            
            string profileId,            
            string userId            
        )
        {
            PathParams["attributeName"] = attributeName;
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.Attribute? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Attribute>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Attribute>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}