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
    /// SpecificEventTypeDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SpecificEventTypeDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SpecificEventTypeDescriptionHandlerBuilder Builder = new SpecificEventTypeDescriptionHandlerBuilder();

        public class SpecificEventTypeDescriptionHandlerBuilder
        {
            public string? EventTypes { get; set; }
            
            internal SpecificEventTypeDescriptionHandlerBuilder() { }


            public SpecificEventTypeDescriptionHandlerBuilder SetEventTypes(string _eventTypes)
            {
                EventTypes = _eventTypes;
                return this;
            }




            public SpecificEventTypeDescriptionHandler Build(
            )
            {
                return new SpecificEventTypeDescriptionHandler(this
                );
            }
        }

        private SpecificEventTypeDescriptionHandler(SpecificEventTypeDescriptionHandlerBuilder builder
        )
        {
            
            if (builder.EventTypes != null) QueryParams["eventTypes"] = builder.EventTypes;
            
            
            
            
        }
        #endregion

        public SpecificEventTypeDescriptionHandler(
            string? eventTypes            
        )
        {
            
            if (eventTypes != null) QueryParams["eventTypes"] = eventTypes;
            
            
            
            
        }

        public override string Path => "/event/descriptions/eventType/listByEventTypes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsMultipleEventType? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventType>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventType>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}