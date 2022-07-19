// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation.Deprecated
{
    /// <summary>
    /// GetRegisteredEventIDHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [READ]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetRegisteredEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRegisteredEventIDHandlerBuilder Builder = new GetRegisteredEventIDHandlerBuilder();

        public class GetRegisteredEventIDHandlerBuilder
            : OperationBuilder<GetRegisteredEventIDHandlerBuilder>
        {





            internal GetRegisteredEventIDHandlerBuilder() { }






            public GetRegisteredEventIDHandler Build(
                string eventId
            )
            {
                GetRegisteredEventIDHandler op = new GetRegisteredEventIDHandler(this,
                    eventId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetRegisteredEventIDHandler(GetRegisteredEventIDHandlerBuilder builder,
            string eventId
        )
        {
            PathParams["eventId"] = eventId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRegisteredEventIDHandler(
            string eventId            
        )
        {
            PathParams["eventId"] = eventId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventIds/{eventId}";

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