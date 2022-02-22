// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetCustomAttributesInfo
    ///
    /// Get custom attributes info.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=2 (READ)
    ///   *  Action code : 11404
    ///   *  Returns : user custom attributes
    /// </summary>
    public class PublicGetCustomAttributesInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCustomAttributesInfoBuilder Builder = new PublicGetCustomAttributesInfoBuilder();

        public class PublicGetCustomAttributesInfoBuilder
        {
            
            
            internal PublicGetCustomAttributesInfoBuilder() { }





            public PublicGetCustomAttributesInfo Build(
                string namespace_,
                string userId
            )
            {
                return new PublicGetCustomAttributesInfo(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicGetCustomAttributesInfo(PublicGetCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public PublicGetCustomAttributesInfo(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/customAttributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}