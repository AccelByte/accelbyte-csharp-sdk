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
    /// GetEventByUserIDAndEventTypeHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetEventByUserIDAndEventTypeHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventByUserIDAndEventTypeHandlerBuilder Builder = new GetEventByUserIDAndEventTypeHandlerBuilder();

        public class GetEventByUserIDAndEventTypeHandlerBuilder
        {
            
            
            
            public long? Offset { get; set; }
            
            
            
            
            internal GetEventByUserIDAndEventTypeHandlerBuilder() { }


            public GetEventByUserIDAndEventTypeHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetEventByUserIDAndEventTypeHandler Build(
                double eventType,
                string namespace_,
                string userId,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                return new GetEventByUserIDAndEventTypeHandler(this,
                    eventType,                    
                    namespace_,                    
                    userId,                    
                    endDate,                    
                    pageSize,                    
                    startDate                    
                );
            }
        }

        private GetEventByUserIDAndEventTypeHandler(GetEventByUserIDAndEventTypeHandlerBuilder builder,
            double eventType,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["eventType"] = Convert.ToString(eventType);
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate != null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            
        }
        #endregion

        public GetEventByUserIDAndEventTypeHandler(
            double eventType,            
            string namespace_,            
            string userId,            
            long? offset,            
            string endDate,            
            long pageSize,            
            string startDate            
        )
        {
            PathParams["eventType"] = Convert.ToString(eventType);
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate != null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}/eventType/{eventType}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}