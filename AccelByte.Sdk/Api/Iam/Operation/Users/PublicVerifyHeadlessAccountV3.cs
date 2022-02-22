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
    /// PublicVerifyHeadlessAccountV3
    ///
    /// 
    /// 
    /// Require valid user authorization
    /// action code : 10124
    /// </summary>
    public class PublicVerifyHeadlessAccountV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicVerifyHeadlessAccountV3Builder Builder = new PublicVerifyHeadlessAccountV3Builder();

        public class PublicVerifyHeadlessAccountV3Builder
        {
            
            
            internal PublicVerifyHeadlessAccountV3Builder() { }





            public PublicVerifyHeadlessAccountV3 Build(
                ModelUpgradeHeadlessAccountV3Request body,
                string namespace_
            )
            {
                return new PublicVerifyHeadlessAccountV3(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private PublicVerifyHeadlessAccountV3(PublicVerifyHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountV3Request body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicVerifyHeadlessAccountV3(
            string namespace_,            
            Model.ModelUpgradeHeadlessAccountV3Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/headless/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}