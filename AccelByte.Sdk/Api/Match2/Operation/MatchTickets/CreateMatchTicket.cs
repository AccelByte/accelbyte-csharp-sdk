// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// CreateMatchTicket
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:TICKET [CREATE]
    /// 
    /// Required Scope: social
    /// 
    /// Creates a new request for matchmaking
    /// </summary>
    public class CreateMatchTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateMatchTicketBuilder Builder = new CreateMatchTicketBuilder();

        public class CreateMatchTicketBuilder
            : OperationBuilder<CreateMatchTicketBuilder>
        {





            internal CreateMatchTicketBuilder() { }






            public CreateMatchTicket Build(
                ApiMatchTicketRequest body,
                string namespace_
            )
            {
                CreateMatchTicket op = new CreateMatchTicket(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateMatchTicket(CreateMatchTicketBuilder builder,
            ApiMatchTicketRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateMatchTicket(
            string namespace_,            
            Model.ApiMatchTicketRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-tickets";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApiMatchTicketResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchTicketResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchTicketResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}