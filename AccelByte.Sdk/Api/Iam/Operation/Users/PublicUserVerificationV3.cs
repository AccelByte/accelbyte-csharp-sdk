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
    /// PublicUserVerificationV3
    ///
    /// 
    /// 
    /// Will consume code if validateOnly is set false
    /// 
    /// 
    /// 
    /// 
    /// Required valid user authorization
    /// 
    /// 
    /// 
    /// 
    /// Redeems a verification code sent to a user to verify the user's contact address is correct
    /// 
    /// 
    /// 
    /// 
    /// Available ContactType : email
    /// 
    /// 
    /// 
    /// 
    /// action code: 10107
    /// </summary>
    public class PublicUserVerificationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUserVerificationV3Builder Builder = new PublicUserVerificationV3Builder();

        public class PublicUserVerificationV3Builder
            : OperationBuilder<PublicUserVerificationV3Builder>
        {
            
            
            internal PublicUserVerificationV3Builder() { }





            public PublicUserVerificationV3 Build(
                ModelUserVerificationRequestV3 body,
                string namespace_
            )
            {
                PublicUserVerificationV3 op = new PublicUserVerificationV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUserVerificationV3(PublicUserVerificationV3Builder builder,
            ModelUserVerificationRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUserVerificationV3(
            string namespace_,            
            Model.ModelUserVerificationRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/code/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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