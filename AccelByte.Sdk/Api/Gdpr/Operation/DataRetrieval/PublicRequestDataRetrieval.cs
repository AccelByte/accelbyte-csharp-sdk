// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// PublicRequestDataRetrieval
    ///
    /// Requires valid user access token
    /// </summary>
    public class PublicRequestDataRetrieval : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicRequestDataRetrievalBuilder Builder = new PublicRequestDataRetrievalBuilder();

        public class PublicRequestDataRetrievalBuilder
            : OperationBuilder<PublicRequestDataRetrievalBuilder>
        {





            internal PublicRequestDataRetrievalBuilder() { }






            public PublicRequestDataRetrieval Build(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicRequestDataRetrieval op = new PublicRequestDataRetrieval(this,
                    password,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicRequestDataRetrieval(PublicRequestDataRetrievalBuilder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicRequestDataRetrieval(
            string namespace_,            
            string userId,            
            string password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/requests";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsDataRetrievalResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDataRetrievalResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDataRetrievalResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}