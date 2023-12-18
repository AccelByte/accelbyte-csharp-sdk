// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// deleteTicket
    ///
    /// This endpoint will delete ticket and all its reports.
    /// </summary>
    public class DeleteTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTicketBuilder Builder { get => new DeleteTicketBuilder(); }

        public class DeleteTicketBuilder
            : OperationBuilder<DeleteTicketBuilder>
        {





            internal DeleteTicketBuilder() { }






            public DeleteTicket Build(
                string namespace_,
                string ticketId
            )
            {
                DeleteTicket op = new DeleteTicket(this,
                    namespace_,
                    ticketId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private DeleteTicket(DeleteTicketBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteTicket(
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}";

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