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
    /// PublicCreateUserV3
    ///
    /// 
    /// 
    /// 
    /// Available Authentication Types:
    /// 
    /// 
    /// 
    /// 
    ///                   1.  EMAILPASSWD : an authentication type used for new user registration through email.
    /// 
    /// 
    /// 
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// 
    /// 
    /// 
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint support accepting agreements for the created user. Supply the accepted agreements in acceptedPolicies attribute.
    /// </summary>
    public class PublicCreateUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserV3Builder Builder = new PublicCreateUserV3Builder();

        public class PublicCreateUserV3Builder
            : OperationBuilder<PublicCreateUserV3Builder>
        {
            
            
            internal PublicCreateUserV3Builder() { }






            public PublicCreateUserV3 Build(
                ModelUserCreateRequestV3 body,
                string namespace_
            )
            {
                PublicCreateUserV3 op = new PublicCreateUserV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCreateUserV3(PublicCreateUserV3Builder builder,
            ModelUserCreateRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateUserV3(
            string namespace_,            
            Model.ModelUserCreateRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelUserCreateResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}