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
    /// publicCreateProfile
    ///
    /// Create new profile for user.
    /// Other detail info:
    ///         *  Required permission
    /// : resource="NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=1 (CREATE)
    ///         *  Returns
    /// : created game profile
    /// </summary>
    public class PublicCreateProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateProfileBuilder Builder = new PublicCreateProfileBuilder();

        public class PublicCreateProfileBuilder
            : OperationBuilder<PublicCreateProfileBuilder>
        {
            
            
            public Model.GameProfileRequest? Body { get; set; }
            
            internal PublicCreateProfileBuilder() { }



            public PublicCreateProfileBuilder SetBody(Model.GameProfileRequest _body)
            {
                Body = _body;
                return this;
            }



            public PublicCreateProfile Build(
                string namespace_,
                string userId
            )
            {
                PublicCreateProfile op = new PublicCreateProfile(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCreateProfile(PublicCreateProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateProfile(
            string namespace_,            
            string userId,            
            Model.GameProfileRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}