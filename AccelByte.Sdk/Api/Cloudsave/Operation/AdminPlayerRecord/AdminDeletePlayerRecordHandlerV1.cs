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
    /// adminDeletePlayerRecordHandlerV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [DELETE]`
    /// 
    /// Required scope: `social`
    /// 
    /// Delete a record (arbitrary JSON data) in user-level with given key.
    /// </summary>
    public class AdminDeletePlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlayerRecordHandlerV1Builder Builder = new AdminDeletePlayerRecordHandlerV1Builder();

        public class AdminDeletePlayerRecordHandlerV1Builder
        {
            
            
            
            internal AdminDeletePlayerRecordHandlerV1Builder() { }





            public AdminDeletePlayerRecordHandlerV1 Build(
                string key,
                string namespace_,
                string userId
            )
            {
                return new AdminDeletePlayerRecordHandlerV1(this,
                    key,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminDeletePlayerRecordHandlerV1(AdminDeletePlayerRecordHandlerV1Builder builder,
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

        public AdminDeletePlayerRecordHandlerV1(
            string key,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}";

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