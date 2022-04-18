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
    /// SpecificAgentTypeDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SpecificAgentTypeDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SpecificAgentTypeDescriptionHandlerBuilder Builder = new SpecificAgentTypeDescriptionHandlerBuilder();

        public class SpecificAgentTypeDescriptionHandlerBuilder
            : OperationBuilder<SpecificAgentTypeDescriptionHandlerBuilder>
        {
            public string? AgentTypes { get; set; }
            
            internal SpecificAgentTypeDescriptionHandlerBuilder() { }


            public SpecificAgentTypeDescriptionHandlerBuilder SetAgentTypes(string _agentTypes)
            {
                AgentTypes = _agentTypes;
                return this;
            }




            public SpecificAgentTypeDescriptionHandler Build(
            )
            {
                SpecificAgentTypeDescriptionHandler op = new SpecificAgentTypeDescriptionHandler(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SpecificAgentTypeDescriptionHandler(SpecificAgentTypeDescriptionHandlerBuilder builder
        )
        {
            
            if (builder.AgentTypes != null) QueryParams["agentTypes"] = builder.AgentTypes;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SpecificAgentTypeDescriptionHandler(
            string? agentTypes            
        )
        {
            
            if (agentTypes != null) QueryParams["agentTypes"] = agentTypes;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/descriptions/agentType/listByAgentTypes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsMultipleAgentType? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleAgentType>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleAgentType>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}