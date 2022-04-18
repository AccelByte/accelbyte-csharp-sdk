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
    /// getUserProfiles
    ///
    /// Returns all profiles' header for a user.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=2 (READ)
    ///         *  Returns : list of profiles
    /// </summary>
    public class GetUserProfiles : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserProfilesBuilder Builder = new GetUserProfilesBuilder();

        public class GetUserProfilesBuilder
            : OperationBuilder<GetUserProfilesBuilder>
        {
            
            
            internal GetUserProfilesBuilder() { }





            public GetUserProfiles Build(
                string namespace_,
                string userId
            )
            {
                GetUserProfiles op = new GetUserProfiles(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserProfiles(GetUserProfilesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserProfiles(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.GameProfileHeader>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.GameProfileHeader>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.GameProfileHeader>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}