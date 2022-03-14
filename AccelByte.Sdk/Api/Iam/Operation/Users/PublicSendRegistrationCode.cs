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
    /// PublicSendRegistrationCode
    ///
    /// This endpoint will validate the request's email address.
    /// 
    /// If it already been used, will response 409.
    /// 
    /// If it is available, we will send a verification code to this email address.
    /// This code can be verified by this endpoint.
    /// </summary>
    public class PublicSendRegistrationCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSendRegistrationCodeBuilder Builder = new PublicSendRegistrationCodeBuilder();

        public class PublicSendRegistrationCodeBuilder
        {
            
            
            internal PublicSendRegistrationCodeBuilder() { }





            public PublicSendRegistrationCode Build(
                ModelSendRegisterVerificationCodeRequest body,
                string namespace_
            )
            {
                return new PublicSendRegistrationCode(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private PublicSendRegistrationCode(PublicSendRegistrationCodeBuilder builder,
            ModelSendRegisterVerificationCodeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicSendRegistrationCode(
            string namespace_,            
            Model.ModelSendRegisterVerificationCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/code/request";

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