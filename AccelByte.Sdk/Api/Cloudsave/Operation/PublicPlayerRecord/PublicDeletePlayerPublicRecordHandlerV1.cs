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
    /// Required valid user authorization
    /// Required scope: `social`
    /// 
    /// Delete player public record.
    /// 
    /// 
    /// 
    /// 
    /// ## Warning: This endpoint is going to deprecate
    /// 
    /// 
    /// 
    /// This endpoint is going to deprecate in the future please don't use it.
    /// 
    /// For alternative, please use these endpoints:
    /// - POST /cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key} and utilizing __META functionality
    /// - PUT /cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key} and utilizing __META functionality
    /// - DELETE /cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}
    /// </summary>
    public class PublicDeletePlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePlayerPublicRecordHandlerV1Builder Builder = new PublicDeletePlayerPublicRecordHandlerV1Builder();

        public class PublicDeletePlayerPublicRecordHandlerV1Builder
            : OperationBuilder<PublicDeletePlayerPublicRecordHandlerV1Builder>
        {
            
            
            internal PublicDeletePlayerPublicRecordHandlerV1Builder() { }






            public PublicDeletePlayerPublicRecordHandlerV1 Build(
                string key,
                string namespace_
            )
            {
                PublicDeletePlayerPublicRecordHandlerV1 op = new PublicDeletePlayerPublicRecordHandlerV1(this,
                    key,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicDeletePlayerPublicRecordHandlerV1(PublicDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDeletePlayerPublicRecordHandlerV1(
            string key,            
            string namespace_            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Delete;

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