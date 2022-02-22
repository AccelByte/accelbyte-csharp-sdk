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
    /// adminGetPlayerPublicRecordHandlerV1
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [READ]
    /// 
    /// Required scope: social
    /// 
    /// Get a record in user-level (arbitrary JSON data) by its key.
    /// </summary>
    public class AdminGetPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetPlayerPublicRecordHandlerV1Builder Builder = new AdminGetPlayerPublicRecordHandlerV1Builder();

        public class AdminGetPlayerPublicRecordHandlerV1Builder
        {
            
            
            
            internal AdminGetPlayerPublicRecordHandlerV1Builder() { }





            public AdminGetPlayerPublicRecordHandlerV1 Build(
                string key,
                string namespace_,
                string userId
            )
            {
                return new AdminGetPlayerPublicRecordHandlerV1(this,
                    key,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminGetPlayerPublicRecordHandlerV1(AdminGetPlayerPublicRecordHandlerV1Builder builder,
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

        public AdminGetPlayerPublicRecordHandlerV1(
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

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPlayerRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecord>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecord>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}