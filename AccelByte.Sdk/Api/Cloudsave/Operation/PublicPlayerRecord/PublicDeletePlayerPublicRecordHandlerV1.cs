// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// publicDeletePlayerPublicRecordHandlerV1
    ///
    /// Required scope: `social`
    /// 
    /// Required valid user authorization
    /// 
    /// Delete player public record (arbitrary JSON data) in user-level with given key.
    /// </summary>
    public class PublicDeletePlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePlayerPublicRecordHandlerV1Builder Builder = new PublicDeletePlayerPublicRecordHandlerV1Builder();

        public class PublicDeletePlayerPublicRecordHandlerV1Builder
        {
            
            
            internal PublicDeletePlayerPublicRecordHandlerV1Builder() { }





            public PublicDeletePlayerPublicRecordHandlerV1 Build(
                string key,
                string namespace_
            )
            {
                return new PublicDeletePlayerPublicRecordHandlerV1(this,
                    key,                    
                    namespace_                    
                );
            }
        }

        private PublicDeletePlayerPublicRecordHandlerV1(PublicDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public PublicDeletePlayerPublicRecordHandlerV1(
            string key,            
            string namespace_            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Delete;

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