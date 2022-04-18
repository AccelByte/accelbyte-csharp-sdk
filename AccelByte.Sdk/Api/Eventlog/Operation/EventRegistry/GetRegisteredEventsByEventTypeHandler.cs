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
    /// GetRegisteredEventsByEventTypeHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [READ]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetRegisteredEventsByEventTypeHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRegisteredEventsByEventTypeHandlerBuilder Builder = new GetRegisteredEventsByEventTypeHandlerBuilder();

        public class GetRegisteredEventsByEventTypeHandlerBuilder
            : OperationBuilder<GetRegisteredEventsByEventTypeHandlerBuilder>
        {
            
            internal GetRegisteredEventsByEventTypeHandlerBuilder() { }





            public GetRegisteredEventsByEventTypeHandler Build(
                string eventType
            )
            {
                GetRegisteredEventsByEventTypeHandler op = new GetRegisteredEventsByEventTypeHandler(this,
                    eventType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetRegisteredEventsByEventTypeHandler(GetRegisteredEventsByEventTypeHandlerBuilder builder,
            string eventType
        )
        {
            PathParams["eventType"] = eventType;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRegisteredEventsByEventTypeHandler(
            string eventType            
        )
        {
            PathParams["eventType"] = eventType;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventTypes/{eventType}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsEventRegistry? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventRegistry>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventRegistry>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}