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
    /// bulkGetPlayerPublicRecordHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:PUBLIC:CLOUDSAVE:RECORD [READ]`
    /// --------------------|--------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Bulk get other player's record that is public by userIds, max allowed 20 at a time. Only record with `isPublic=true` that can be
    /// retrieved using this endpoint.
    /// </summary>
    public class BulkGetPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetPlayerPublicRecordHandlerV1Builder Builder = new BulkGetPlayerPublicRecordHandlerV1Builder();

        public class BulkGetPlayerPublicRecordHandlerV1Builder
            : OperationBuilder<BulkGetPlayerPublicRecordHandlerV1Builder>
        {
            
            
            
            internal BulkGetPlayerPublicRecordHandlerV1Builder() { }





            public BulkGetPlayerPublicRecordHandlerV1 Build(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                BulkGetPlayerPublicRecordHandlerV1 op = new BulkGetPlayerPublicRecordHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkGetPlayerPublicRecordHandlerV1(BulkGetPlayerPublicRecordHandlerV1Builder builder,
            ModelsBulkUserIDsRequest body,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetPlayerPublicRecordHandlerV1(
            string key,            
            string namespace_,            
            Model.ModelsBulkUserIDsRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/bulk/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsBulkGetPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}