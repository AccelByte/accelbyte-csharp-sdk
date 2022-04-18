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
    /// UpdateEventRegistryHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [UPDATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UpdateEventRegistryHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateEventRegistryHandlerBuilder Builder = new UpdateEventRegistryHandlerBuilder();

        public class UpdateEventRegistryHandlerBuilder
            : OperationBuilder<UpdateEventRegistryHandlerBuilder>
        {
            
            
            internal UpdateEventRegistryHandlerBuilder() { }





            public UpdateEventRegistryHandler Build(
                ModelsEventRegistry body,
                string eventId
            )
            {
                UpdateEventRegistryHandler op = new UpdateEventRegistryHandler(this,
                    body,                    
                    eventId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateEventRegistryHandler(UpdateEventRegistryHandlerBuilder builder,
            ModelsEventRegistry body,
            string eventId
        )
        {
            PathParams["eventId"] = eventId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateEventRegistryHandler(
            string eventId,            
            Model.ModelsEventRegistry body            
        )
        {
            PathParams["eventId"] = eventId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventIds/{eventId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}