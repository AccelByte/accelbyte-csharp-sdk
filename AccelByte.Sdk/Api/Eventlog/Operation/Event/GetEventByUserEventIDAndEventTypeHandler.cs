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
    /// GetEventByUserEventIDAndEventTypeHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetEventByUserEventIDAndEventTypeHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventByUserEventIDAndEventTypeHandlerBuilder Builder = new GetEventByUserEventIDAndEventTypeHandlerBuilder();

        public class GetEventByUserEventIDAndEventTypeHandlerBuilder
            : OperationBuilder<GetEventByUserEventIDAndEventTypeHandlerBuilder>
        {
            
            
            
            
            public long? Offset { get; set; }
            
            
            
            
            internal GetEventByUserEventIDAndEventTypeHandlerBuilder() { }


            public GetEventByUserEventIDAndEventTypeHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetEventByUserEventIDAndEventTypeHandler Build(
                double eventId,
                double eventType,
                string namespace_,
                string userId,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByUserEventIDAndEventTypeHandler op = new GetEventByUserEventIDAndEventTypeHandler(this,
                    eventId,                    
                    eventType,                    
                    namespace_,                    
                    userId,                    
                    endDate,                    
                    pageSize,                    
                    startDate                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetEventByUserEventIDAndEventTypeHandler(GetEventByUserEventIDAndEventTypeHandlerBuilder builder,
            double eventId,
            double eventType,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["eventType"] = Convert.ToString(eventType);
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate != null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEventByUserEventIDAndEventTypeHandler(
            double eventId,            
            double eventType,            
            string namespace_,            
            string userId,            
            long? offset,            
            string endDate,            
            long pageSize,            
            string startDate            
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["eventType"] = Convert.ToString(eventType);
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate != null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}/eventType/{eventType}/eventId/{eventId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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