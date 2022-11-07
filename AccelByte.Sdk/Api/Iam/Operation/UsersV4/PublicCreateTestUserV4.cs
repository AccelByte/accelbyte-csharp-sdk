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
    /// PublicCreateTestUserV4
    ///
    /// Create a test user and not send verification code email
    /// 
    /// 
    /// 
    /// Required attributes:
    /// - verified: this new user is verified or not
    /// - authType: possible value is EMAILPASSWD
    /// - emailAddress: Please refer to the rule from /v3/public/inputValidations API.
    /// - username: Please refer to the rule from /v3/public/inputValidations API.
    /// - password: Please refer to the rule from /v3/public/inputValidations API.
    /// - country: ISO3166-1 alpha-2 two letter, e.g. US.
    /// - dateOfBirth: YYYY-MM-DD, e.g. 1990-01-01. valid values are between 1905-01-01 until current date.
    /// 
    /// 
    /// Not required attributes:
    /// - displayName: Please refer to the rule from /v3/public/inputValidations API.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This endpoint support accepting agreements for the created user. Supply the accepted agreements in acceptedPolicies attribute.
    /// </summary>
    public class PublicCreateTestUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateTestUserV4Builder Builder = new PublicCreateTestUserV4Builder();

        public class PublicCreateTestUserV4Builder
            : OperationBuilder<PublicCreateTestUserV4Builder>
        {





            internal PublicCreateTestUserV4Builder() { }






            public PublicCreateTestUserV4 Build(
                AccountCreateTestUserRequestV4 body,
                string namespace_
            )
            {
                PublicCreateTestUserV4 op = new PublicCreateTestUserV4(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCreateTestUserV4(PublicCreateTestUserV4Builder builder,
            AccountCreateTestUserRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateTestUserV4(
            string namespace_,            
            Model.AccountCreateTestUserRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/test_users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AccountCreateUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}