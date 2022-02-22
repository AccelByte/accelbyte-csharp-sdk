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
    /// EventIDDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class EventIDDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EventIDDescriptionHandlerBuilder Builder = new EventIDDescriptionHandlerBuilder();

        public class EventIDDescriptionHandlerBuilder
        {
            internal EventIDDescriptionHandlerBuilder() { }





            public EventIDDescriptionHandler Build(
            )
            {
                return new EventIDDescriptionHandler(this
                );
            }
        }

        private EventIDDescriptionHandler(EventIDDescriptionHandlerBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public EventIDDescriptionHandler(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/event/descriptions/eventId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsMultipleEventID? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventID>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventID>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}