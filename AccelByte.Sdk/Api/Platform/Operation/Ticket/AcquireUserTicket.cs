// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// acquireUserTicket
    ///
    ///  [SERVICE COMMUNICATION ONLY] Acquire ticket(code/key) based on booth name.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:TICKET", action=1 (CREATE)
    ///   *  Returns : acquire result
    /// </summary>
    public class AcquireUserTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AcquireUserTicketBuilder Builder = new AcquireUserTicketBuilder();

        public class AcquireUserTicketBuilder
            : OperationBuilder<AcquireUserTicketBuilder>
        {
            
            
            
            public Model.TicketAcquireRequest? Body { get; set; }
            
            internal AcquireUserTicketBuilder() { }



            public AcquireUserTicketBuilder SetBody(Model.TicketAcquireRequest _body)
            {
                Body = _body;
                return this;
            }



            public AcquireUserTicket Build(
                string boothName,
                string namespace_,
                string userId
            )
            {
                AcquireUserTicket op = new AcquireUserTicket(this,
                    boothName,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AcquireUserTicket(AcquireUserTicketBuilder builder,
            string boothName,
            string namespace_,
            string userId
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AcquireUserTicket(
            string boothName,            
            string namespace_,            
            string userId,            
            Model.TicketAcquireRequest body            
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/tickets/{boothName}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.TicketAcquireResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TicketAcquireResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TicketAcquireResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}