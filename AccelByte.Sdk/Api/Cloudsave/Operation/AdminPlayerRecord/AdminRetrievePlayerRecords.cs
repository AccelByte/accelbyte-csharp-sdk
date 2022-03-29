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
    /// AdminRetrievePlayerRecords
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:USER:{userId}:RECORD [READ]`
    /// 
    /// Required scope: `social`
    /// 
    /// Retrieve list of player records key and userID under given namespace.
    /// </summary>
    public class AdminRetrievePlayerRecords : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRetrievePlayerRecordsBuilder Builder = new AdminRetrievePlayerRecordsBuilder();

        public class AdminRetrievePlayerRecordsBuilder
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal AdminRetrievePlayerRecordsBuilder() { }


            public AdminRetrievePlayerRecordsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminRetrievePlayerRecordsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public AdminRetrievePlayerRecords Build(
                string namespace_,
                string userId
            )
            {
                return new AdminRetrievePlayerRecords(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminRetrievePlayerRecords(AdminRetrievePlayerRecordsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public AdminRetrievePlayerRecords(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListPlayerRecordKeysResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}