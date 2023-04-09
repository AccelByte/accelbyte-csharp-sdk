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
    /// DeleteMatchTicket
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:TICKET [DELETE]
    /// 
    /// Required Scope: social
    /// 
    /// Deletes an existing matchmaking ticket.
    /// </summary>
    public class DeleteMatchTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMatchTicketBuilder Builder { get => new DeleteMatchTicketBuilder(); }

        public class DeleteMatchTicketBuilder
            : OperationBuilder<DeleteMatchTicketBuilder>
        {





            internal DeleteMatchTicketBuilder() { }






            public DeleteMatchTicket Build(
                string namespace_,
                string ticketid
            )
            {
                DeleteMatchTicket op = new DeleteMatchTicket(this,
                    namespace_,
                    ticketid
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteMatchTicket(DeleteMatchTicketBuilder builder,
            string namespace_,
            string ticketid
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketid"] = ticketid;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMatchTicket(
            string namespace_,
            string ticketid
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketid"] = ticketid;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-tickets/{ticketid}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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