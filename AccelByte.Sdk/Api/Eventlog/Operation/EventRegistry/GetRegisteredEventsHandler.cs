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
    /// GetRegisteredEventsHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [READ]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetRegisteredEventsHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRegisteredEventsHandlerBuilder Builder = new GetRegisteredEventsHandlerBuilder();

        public class GetRegisteredEventsHandlerBuilder
        {
            internal GetRegisteredEventsHandlerBuilder() { }





            public GetRegisteredEventsHandler Build(
            )
            {
                return new GetRegisteredEventsHandler(this
                );
            }
        }

        private GetRegisteredEventsHandler(GetRegisteredEventsHandlerBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public GetRegisteredEventsHandler(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/event/registry/eventIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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