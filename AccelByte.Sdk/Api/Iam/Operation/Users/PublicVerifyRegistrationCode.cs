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
    /// PublicVerifyRegistrationCode
    ///
    /// 
    /// 
    /// Verify the registration code
    /// </summary>
    public class PublicVerifyRegistrationCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicVerifyRegistrationCodeBuilder Builder = new PublicVerifyRegistrationCodeBuilder();

        public class PublicVerifyRegistrationCodeBuilder
        {
            
            
            internal PublicVerifyRegistrationCodeBuilder() { }





            public PublicVerifyRegistrationCode Build(
                ModelVerifyRegistrationCode body,
                string namespace_
            )
            {
                return new PublicVerifyRegistrationCode(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private PublicVerifyRegistrationCode(PublicVerifyRegistrationCodeBuilder builder,
            ModelVerifyRegistrationCode body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicVerifyRegistrationCode(
            string namespace_,            
            Model.ModelVerifyRegistrationCode body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/code/verify";

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