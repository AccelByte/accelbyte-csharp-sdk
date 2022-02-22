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
    /// PublicValidateUserByUserIDAndPasswordV3
    ///
    /// This endpoint is used to validate the user password. Required valid user authorization and valid user ID.
    /// 
    /// 
    /// Notes:
    /// 
    /// 
    /// 
    /// 
    ///                           * This endpoint validate the user password by specifying the userId and password
    /// </summary>
    public class PublicValidateUserByUserIDAndPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicValidateUserByUserIDAndPasswordV3Builder Builder = new PublicValidateUserByUserIDAndPasswordV3Builder();

        public class PublicValidateUserByUserIDAndPasswordV3Builder
        {
            
            
            
            internal PublicValidateUserByUserIDAndPasswordV3Builder() { }





            public PublicValidateUserByUserIDAndPasswordV3 Build(
                string password,
                string namespace_,
                string userId
            )
            {
                return new PublicValidateUserByUserIDAndPasswordV3(this,
                    password,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicValidateUserByUserIDAndPasswordV3(PublicValidateUserByUserIDAndPasswordV3Builder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password != null) FormParams["password"] = password;
            
            
            
        }
        #endregion

        public PublicValidateUserByUserIDAndPasswordV3(
            string namespace_,            
            string userId,            
            string password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password != null) FormParams["password"] = password;
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

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