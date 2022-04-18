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
    /// publicUpdateUserProfileStatus
    ///
    /// Update user profile status.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=4 (UPDATE)
    ///   *  Action code : 11406
    ///   *  Returns : user profile
    /// </summary>
    public class PublicUpdateUserProfileStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserProfileStatusBuilder Builder = new PublicUpdateUserProfileStatusBuilder();

        public class PublicUpdateUserProfileStatusBuilder
            : OperationBuilder<PublicUpdateUserProfileStatusBuilder>
        {
            
            
            public Model.UserProfileStatusUpdate? Body { get; set; }
            
            internal PublicUpdateUserProfileStatusBuilder() { }



            public PublicUpdateUserProfileStatusBuilder SetBody(Model.UserProfileStatusUpdate _body)
            {
                Body = _body;
                return this;
            }



            public PublicUpdateUserProfileStatus Build(
                string namespace_,
                string userId
            )
            {
                PublicUpdateUserProfileStatus op = new PublicUpdateUserProfileStatus(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUpdateUserProfileStatus(PublicUpdateUserProfileStatusBuilder builder,
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

        public PublicUpdateUserProfileStatus(
            string namespace_,            
            string userId,            
            Model.UserProfileStatusUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/status";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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