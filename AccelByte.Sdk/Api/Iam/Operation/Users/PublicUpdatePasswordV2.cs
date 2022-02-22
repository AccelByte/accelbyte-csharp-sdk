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
    /// PublicUpdatePasswordV2
    ///
    /// This endpoint need a valid user access token
    /// </summary>
    public class PublicUpdatePasswordV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePasswordV2Builder Builder = new PublicUpdatePasswordV2Builder();

        public class PublicUpdatePasswordV2Builder
        {
            
            
            
            internal PublicUpdatePasswordV2Builder() { }





            public PublicUpdatePasswordV2 Build(
                ModelUserPasswordUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                return new PublicUpdatePasswordV2(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicUpdatePasswordV2(PublicUpdatePasswordV2Builder builder,
            ModelUserPasswordUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicUpdatePasswordV2(
            string namespace_,            
            string userId,            
            Model.ModelUserPasswordUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}/password";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

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