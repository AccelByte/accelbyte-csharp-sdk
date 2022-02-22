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
    /// listGameRecordsHandlerV1
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [READ]
    /// 
    /// Required scope: social
    /// 
    /// Retrieve list of records key by namespace
    /// </summary>
    public class ListGameRecordsHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListGameRecordsHandlerV1Builder Builder = new ListGameRecordsHandlerV1Builder();

        public class ListGameRecordsHandlerV1Builder
        {
            
            public string? Query { get; set; }
            
            
            
            internal ListGameRecordsHandlerV1Builder() { }


            public ListGameRecordsHandlerV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }




            public ListGameRecordsHandlerV1 Build(
                string namespace_,
                long limit,
                long offset
            )
            {
                return new ListGameRecordsHandlerV1(this,
                    namespace_,                    
                    limit,                    
                    offset                    
                );
            }
        }

        private ListGameRecordsHandlerV1(ListGameRecordsHandlerV1Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Query != null) QueryParams["query"] = builder.Query;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }
        #endregion

        public ListGameRecordsHandlerV1(
            string namespace_,            
            string? query,            
            long limit,            
            long offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (query != null) QueryParams["query"] = query;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListGameRecordKeys? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListGameRecordKeys>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListGameRecordKeys>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}