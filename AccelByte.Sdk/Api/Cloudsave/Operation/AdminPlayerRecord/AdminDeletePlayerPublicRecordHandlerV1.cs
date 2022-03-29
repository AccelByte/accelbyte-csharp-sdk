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
    /// adminDeletePlayerPublicRecordHandlerV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [DELETE]`
    /// 
    /// Required scope: `social`
    /// 
    /// Delete a public record (arbitrary JSON data) in user-level with given key.
    /// </summary>
    public class AdminDeletePlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlayerPublicRecordHandlerV1Builder Builder = new AdminDeletePlayerPublicRecordHandlerV1Builder();

        public class AdminDeletePlayerPublicRecordHandlerV1Builder
        {
            
            
            
            internal AdminDeletePlayerPublicRecordHandlerV1Builder() { }





            public AdminDeletePlayerPublicRecordHandlerV1 Build(
                string key,
                string namespace_,
                string userId
            )
            {
                return new AdminDeletePlayerPublicRecordHandlerV1(this,
                    key,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminDeletePlayerPublicRecordHandlerV1(AdminDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminDeletePlayerPublicRecordHandlerV1(
            string key,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public";

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