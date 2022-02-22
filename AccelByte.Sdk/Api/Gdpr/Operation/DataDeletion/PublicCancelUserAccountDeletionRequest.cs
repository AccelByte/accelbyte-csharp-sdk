// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// PublicCancelUserAccountDeletionRequest
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// </summary>
    public class PublicCancelUserAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCancelUserAccountDeletionRequestBuilder Builder = new PublicCancelUserAccountDeletionRequestBuilder();

        public class PublicCancelUserAccountDeletionRequestBuilder
        {
            
            
            internal PublicCancelUserAccountDeletionRequestBuilder() { }





            public PublicCancelUserAccountDeletionRequest Build(
                string namespace_,
                string userId
            )
            {
                return new PublicCancelUserAccountDeletionRequest(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicCancelUserAccountDeletionRequest(PublicCancelUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public PublicCancelUserAccountDeletionRequest(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/deletions";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}