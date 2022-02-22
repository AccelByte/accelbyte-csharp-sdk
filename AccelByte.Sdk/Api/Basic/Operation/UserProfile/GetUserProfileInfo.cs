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
    /// getUserProfileInfo
    ///
    /// Get user profile.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=2 (READ)
    ///   *  Returns : user profile
    ///   *  Action code : 11403
    /// </summary>
    public class GetUserProfileInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserProfileInfoBuilder Builder = new GetUserProfileInfoBuilder();

        public class GetUserProfileInfoBuilder
        {
            
            
            internal GetUserProfileInfoBuilder() { }





            public GetUserProfileInfo Build(
                string namespace_,
                string userId
            )
            {
                return new GetUserProfileInfo(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetUserProfileInfo(GetUserProfileInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public GetUserProfileInfo(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserProfilePrivateInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}