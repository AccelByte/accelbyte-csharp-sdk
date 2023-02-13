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
    /// MatchTicketDetails
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:TICKET [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Get details for a specific match ticket
    /// </summary>
    public class MatchTicketDetails : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MatchTicketDetailsBuilder Builder { get => new MatchTicketDetailsBuilder(); }

        public class MatchTicketDetailsBuilder
            : OperationBuilder<MatchTicketDetailsBuilder>
        {





            internal MatchTicketDetailsBuilder() { }






            public MatchTicketDetails Build(
                string namespace_,
                string ticketid
            )
            {
                MatchTicketDetails op = new MatchTicketDetails(this,
                    namespace_,
                    ticketid
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private MatchTicketDetails(MatchTicketDetailsBuilder builder,
            string namespace_,
            string ticketid
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketid"] = ticketid;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public MatchTicketDetails(
            string namespace_,
            string ticketid
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketid"] = ticketid;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-tickets/{ticketid}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiMatchTicketStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchTicketStatus>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchTicketStatus>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}