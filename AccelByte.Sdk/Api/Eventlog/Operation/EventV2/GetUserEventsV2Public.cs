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
    /// GetUserEventsV2Public
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// </summary>
    public class GetUserEventsV2Public : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEventsV2PublicBuilder Builder = new GetUserEventsV2PublicBuilder();

        public class GetUserEventsV2PublicBuilder
        {
            
            
            public string? EndDate { get; set; }
            
            public string? EventName { get; set; }
            
            public long? Offset { get; set; }
            
            public long? PageSize { get; set; }
            
            public string? StartDate { get; set; }
            
            internal GetUserEventsV2PublicBuilder() { }


            public GetUserEventsV2PublicBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public GetUserEventsV2PublicBuilder SetEventName(string _eventName)
            {
                EventName = _eventName;
                return this;
            }

            public GetUserEventsV2PublicBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetUserEventsV2PublicBuilder SetPageSize(long _pageSize)
            {
                PageSize = _pageSize;
                return this;
            }

            public GetUserEventsV2PublicBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }




            public GetUserEventsV2Public Build(
                string namespace_,
                string userId
            )
            {
                return new GetUserEventsV2Public(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetUserEventsV2Public(GetUserEventsV2PublicBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.EndDate != null) QueryParams["endDate"] = builder.EndDate;
            if (builder.EventName != null) QueryParams["eventName"] = builder.EventName;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PageSize != null) QueryParams["pageSize"] = Convert.ToString(builder.PageSize)!;
            if (builder.StartDate != null) QueryParams["startDate"] = builder.StartDate;
            
            
            
            
        }
        #endregion

        public GetUserEventsV2Public(
            string namespace_,            
            string userId,            
            string? endDate,            
            string? eventName,            
            long? offset,            
            long? pageSize,            
            string? startDate            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (endDate != null) QueryParams["endDate"] = endDate;
            if (eventName != null) QueryParams["eventName"] = eventName;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (pageSize != null) QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            
        }

        public override string Path => "/event/v2/public/namespaces/{namespace}/users/{userId}/event";

        public override HttpMethod Method => HttpMethod.Get;

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