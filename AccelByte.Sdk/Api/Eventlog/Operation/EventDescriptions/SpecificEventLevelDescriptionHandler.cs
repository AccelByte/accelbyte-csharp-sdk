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
    /// SpecificEventLevelDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SpecificEventLevelDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SpecificEventLevelDescriptionHandlerBuilder Builder = new SpecificEventLevelDescriptionHandlerBuilder();

        public class SpecificEventLevelDescriptionHandlerBuilder
            : OperationBuilder<SpecificEventLevelDescriptionHandlerBuilder>
        {
            public string? EventLevels { get; set; }
            
            internal SpecificEventLevelDescriptionHandlerBuilder() { }


            public SpecificEventLevelDescriptionHandlerBuilder SetEventLevels(string _eventLevels)
            {
                EventLevels = _eventLevels;
                return this;
            }





            public SpecificEventLevelDescriptionHandler Build(
            )
            {
                SpecificEventLevelDescriptionHandler op = new SpecificEventLevelDescriptionHandler(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SpecificEventLevelDescriptionHandler(SpecificEventLevelDescriptionHandlerBuilder builder
        )
        {
            
            if (builder.EventLevels != null) QueryParams["eventLevels"] = builder.EventLevels;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SpecificEventLevelDescriptionHandler(
            string? eventLevels            
        )
        {
            
            if (eventLevels != null) QueryParams["eventLevels"] = eventLevels;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/descriptions/eventLevel/listByEventLevels";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsMultipleEventLevel? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventLevel>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventLevel>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}