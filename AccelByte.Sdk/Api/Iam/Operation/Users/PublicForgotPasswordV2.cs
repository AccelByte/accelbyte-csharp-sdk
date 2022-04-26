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
    /// PublicForgotPasswordV2
    ///
    /// 
    /// 
    ///  Special note for publisher-game scenario: Game Client should provide game namespace path parameter and Publisher Client should provide publisher namespace path parameter.
    /// 
    /// The password reset code will be sent to the publisher account's email address.
    /// </summary>
    public class PublicForgotPasswordV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicForgotPasswordV2Builder Builder = new PublicForgotPasswordV2Builder();

        public class PublicForgotPasswordV2Builder
            : OperationBuilder<PublicForgotPasswordV2Builder>
        {
            
            
            internal PublicForgotPasswordV2Builder() { }






            public PublicForgotPasswordV2 Build(
                ModelSendVerificationCodeRequest body,
                string namespace_
            )
            {
                PublicForgotPasswordV2 op = new PublicForgotPasswordV2(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicForgotPasswordV2(PublicForgotPasswordV2Builder builder,
            ModelSendVerificationCodeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicForgotPasswordV2(
            string namespace_,            
            Model.ModelSendVerificationCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/forgotPassword";

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