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
    /// RegisterEventHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [CREATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class RegisterEventHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RegisterEventHandlerBuilder Builder = new RegisterEventHandlerBuilder();

        public class RegisterEventHandlerBuilder
            : OperationBuilder<RegisterEventHandlerBuilder>
        {
            
            internal RegisterEventHandlerBuilder() { }






            public RegisterEventHandler Build(
                ModelsEventRegistry body
            )
            {
                RegisterEventHandler op = new RegisterEventHandler(this,
                    body                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RegisterEventHandler(RegisterEventHandlerBuilder builder,
            ModelsEventRegistry body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RegisterEventHandler(
            Model.ModelsEventRegistry body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventIds";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}