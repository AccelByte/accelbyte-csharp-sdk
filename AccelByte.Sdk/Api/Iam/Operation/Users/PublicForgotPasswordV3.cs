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
    /// PublicForgotPasswordV3
    ///
    /// 
    /// 
    /// Special note for publisher-game scenario:
    /// Game Client should provide game namespace path parameter and Publisher
    /// Client should provide publisher namespace path parameter.
    /// 
    /// 
    /// 
    /// 
    /// The password reset code will be sent to the publisher account's email address.
    /// 
    /// 
    /// 
    /// 
    /// action code : 10104
    /// </summary>
    public class PublicForgotPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicForgotPasswordV3Builder Builder = new PublicForgotPasswordV3Builder();

        public class PublicForgotPasswordV3Builder
        {
            
            
            internal PublicForgotPasswordV3Builder() { }





            public PublicForgotPasswordV3 Build(
                ModelForgotPasswordRequestV3 body,
                string namespace_
            )
            {
                return new PublicForgotPasswordV3(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private PublicForgotPasswordV3(PublicForgotPasswordV3Builder builder,
            ModelForgotPasswordRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicForgotPasswordV3(
            string namespace_,            
            Model.ModelForgotPasswordRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/forgot";

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