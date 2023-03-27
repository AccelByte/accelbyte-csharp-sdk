// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RequestGameTokenResponseV3
    ///
    /// 
    /// 
    /// This endpoint is being used to generate publisher user's game token.
    /// 
    /// It require basic header with ClientID and Secret, it should match the ClientID when call /iam/v3/namespace/{namespace}/token/request
    /// 
    /// It required a code which can be generated from /iam/v3/namespace/{namespace}/token/request.
    /// </summary>
    public class RequestGameTokenResponseV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestGameTokenResponseV3Builder Builder { get => new RequestGameTokenResponseV3Builder(); }

        public class RequestGameTokenResponseV3Builder
            : OperationBuilder<RequestGameTokenResponseV3Builder>
        {





            internal RequestGameTokenResponseV3Builder() { }






            public RequestGameTokenResponseV3 Build(
                string code
            )
            {
                RequestGameTokenResponseV3 op = new RequestGameTokenResponseV3(this,
                    code                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RequestGameTokenResponseV3(RequestGameTokenResponseV3Builder builder,
            string code
        )
        {
            
            
            if (code is not null) FormParams["code"] = code;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RequestGameTokenResponseV3(
            string code            
        )
        {
            
            
            if (code is not null) FormParams["code"] = code;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/token/exchange";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}