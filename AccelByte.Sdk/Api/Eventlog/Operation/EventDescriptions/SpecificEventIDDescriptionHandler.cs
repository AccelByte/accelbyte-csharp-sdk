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
    /// SpecificEventIDDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SpecificEventIDDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SpecificEventIDDescriptionHandlerBuilder Builder = new SpecificEventIDDescriptionHandlerBuilder();

        public class SpecificEventIDDescriptionHandlerBuilder
            : OperationBuilder<SpecificEventIDDescriptionHandlerBuilder>
        {
            public string? EventIds { get; set; }
            
            internal SpecificEventIDDescriptionHandlerBuilder() { }


            public SpecificEventIDDescriptionHandlerBuilder SetEventIds(string _eventIds)
            {
                EventIds = _eventIds;
                return this;
            }





            public SpecificEventIDDescriptionHandler Build(
            )
            {
                SpecificEventIDDescriptionHandler op = new SpecificEventIDDescriptionHandler(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SpecificEventIDDescriptionHandler(SpecificEventIDDescriptionHandlerBuilder builder
        )
        {
            
            if (builder.EventIds != null) QueryParams["eventIds"] = builder.EventIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SpecificEventIDDescriptionHandler(
            string? eventIds            
        )
        {
            
            if (eventIds != null) QueryParams["eventIds"] = eventIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/descriptions/eventId/listByEventIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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