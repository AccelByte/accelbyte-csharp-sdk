// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// QueryEventStreamHandler
    ///
    /// 
    /// 
    /// This endpoint is using POST which is somewhat unfamiliar,
    /// but it's logical that we have to send/post a filter (search term) in order to get the data.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will not return anything if you give it an empty filters in the request body.
    /// 
    /// 
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [READ]` and scope `"+scope+"`
    /// </summary>
    public class QueryEventStreamHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryEventStreamHandlerBuilder Builder = new QueryEventStreamHandlerBuilder();

        public class QueryEventStreamHandlerBuilder
        {
            
            public string? EndDate { get; set; }
            
            public long? Offset { get; set; }
            
            public long? PageSize { get; set; }
            
            public string? StartDate { get; set; }
            
            
            internal QueryEventStreamHandlerBuilder() { }


            public QueryEventStreamHandlerBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public QueryEventStreamHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryEventStreamHandlerBuilder SetPageSize(long _pageSize)
            {
                PageSize = _pageSize;
                return this;
            }

            public QueryEventStreamHandlerBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }




            public QueryEventStreamHandler Build(
                ModelsGenericQueryPayload body,
                string namespace_
            )
            {
                return new QueryEventStreamHandler(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private QueryEventStreamHandler(QueryEventStreamHandlerBuilder builder,
            ModelsGenericQueryPayload body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EndDate != null) QueryParams["endDate"] = builder.EndDate;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PageSize != null) QueryParams["pageSize"] = Convert.ToString(builder.PageSize)!;
            if (builder.StartDate != null) QueryParams["startDate"] = builder.StartDate;
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public QueryEventStreamHandler(
            string namespace_,            
            string? endDate,            
            long? offset,            
            long? pageSize,            
            string? startDate,            
            Model.ModelsGenericQueryPayload body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (endDate != null) QueryParams["endDate"] = endDate;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (pageSize != null) QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/event/v2/admin/namespaces/{namespace}/query";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsEventResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponseV2>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponseV2>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}