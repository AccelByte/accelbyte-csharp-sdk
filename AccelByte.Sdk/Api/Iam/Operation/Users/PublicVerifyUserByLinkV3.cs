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
    /// PublicVerifyUserByLinkV3
    /// </summary>
    public class PublicVerifyUserByLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicVerifyUserByLinkV3Builder Builder = new PublicVerifyUserByLinkV3Builder();

        public class PublicVerifyUserByLinkV3Builder
            : OperationBuilder<PublicVerifyUserByLinkV3Builder>
        {

            public string? Code { get; set; }





            internal PublicVerifyUserByLinkV3Builder() { }


            public PublicVerifyUserByLinkV3Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }





            public PublicVerifyUserByLinkV3 Build(
            )
            {
                PublicVerifyUserByLinkV3 op = new PublicVerifyUserByLinkV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicVerifyUserByLinkV3(PublicVerifyUserByLinkV3Builder builder
        )
        {
            
            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicVerifyUserByLinkV3(
            string? code            
        )
        {
            
            if (code is not null) QueryParams["code"] = code;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/verify_link/verify";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            if (code == (HttpStatusCode)302)
            {
              return payloadString;
            }
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}