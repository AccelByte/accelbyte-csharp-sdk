// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// UserVerification
    ///
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// Redeems a verification code sent to a user to verify the user's contact address is correct
    /// 
    /// 
    /// Available ContactType : email or phone
    /// </summary>
    public class UserVerification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserVerificationBuilder Builder = new UserVerificationBuilder();

        public class UserVerificationBuilder
        {
            
            
            
            internal UserVerificationBuilder() { }





            public UserVerification Build(
                ModelUserVerificationRequest body,
                string namespace_,
                string userId
            )
            {
                return new UserVerification(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private UserVerification(UserVerificationBuilder builder,
            ModelUserVerificationRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UserVerification(
            string namespace_,            
            string userId,            
            Model.ModelUserVerificationRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/verification";

        public override HttpMethod Method => HttpMethod.Post;

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