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
    /// PublicUpdatePasswordV3
    ///
    /// Required valid user authorization.
    /// action code: 10107
    /// </summary>
    public class PublicUpdatePasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePasswordV3Builder Builder = new PublicUpdatePasswordV3Builder();

        public class PublicUpdatePasswordV3Builder
            : OperationBuilder<PublicUpdatePasswordV3Builder>
        {
            
            
            internal PublicUpdatePasswordV3Builder() { }






            public PublicUpdatePasswordV3 Build(
                ModelUserPasswordUpdateV3Request body,
                string namespace_
            )
            {
                PublicUpdatePasswordV3 op = new PublicUpdatePasswordV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUpdatePasswordV3(PublicUpdatePasswordV3Builder builder,
            ModelUserPasswordUpdateV3Request body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdatePasswordV3(
            string namespace_,            
            Model.ModelUserPasswordUpdateV3Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/password";

        public override HttpMethod Method => HttpMethod.Put;

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