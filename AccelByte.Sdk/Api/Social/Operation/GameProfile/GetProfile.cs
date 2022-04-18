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
    /// getProfile
    ///
    /// Returns profile for a user.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=2 (READ)
    ///         *  Returns : game profile info
    /// </summary>
    public class GetProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetProfileBuilder Builder = new GetProfileBuilder();

        public class GetProfileBuilder
            : OperationBuilder<GetProfileBuilder>
        {
            
            
            
            internal GetProfileBuilder() { }





            public GetProfile Build(
                string namespace_,
                string profileId,
                string userId
            )
            {
                GetProfile op = new GetProfile(this,
                    namespace_,                    
                    profileId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetProfile(GetProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetProfile(
            string namespace_,            
            string profileId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/profiles/{profileId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.GameProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}