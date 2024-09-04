// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// createXrayBulkTicketObservability
    ///
    /// Create bulk ticket observability request
    /// Request body details (all attributes are optional):
    /// Timestamp : timestamp when calling this endpoint
    /// Action : support one of the following value:
    /// 1. "matchFound"
    /// 2. "matchNotFound"
    /// 3. "flexed"
    /// PartyID : ticket Party ID
    /// MatchID : match ID will be filled only when match found
    /// Namespace : ticket current namespace
    /// GameMode : ticket current matchpool
    /// ActiveAllianceRule : current active alliance ruleset
    /// ActiveMatchingRule : current active matching ruleset
    /// Function : name of the function that called the endpoint
    /// Iteration : total iteration before match found
    /// TimeToMatchSec : time to match (in seconds) will be filled only when match found
    /// UnmatchReason : reason when unable to find match
    /// RemainingTickets : remaining ticket when unable to find match
    /// RemainingPlayersPerTicket : remaining players when unable to find match
    /// UnbackfillReason : reason when unable to backfill
    /// IsBackfillMatch : flag to distinguish between new match and backfill match
    /// IsRuleSetFlexed : flag if ruleset is getting flexed
    /// TickID : tick id for the matchmaking tick
    /// SessionTickID : session tick id for differentiate session when doing matches
    /// </summary>
    public class CreateXrayBulkTicketObservability : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateXrayBulkTicketObservabilityBuilder Builder { get => new CreateXrayBulkTicketObservabilityBuilder(); }

        public class CreateXrayBulkTicketObservabilityBuilder
            : OperationBuilder<CreateXrayBulkTicketObservabilityBuilder>
        {





            internal CreateXrayBulkTicketObservabilityBuilder() { }






            public CreateXrayBulkTicketObservability Build(
                ApimodelsXRayBulkTicketObservabilityRequest body,
                string namespace_
            )
            {
                CreateXrayBulkTicketObservability op = new CreateXrayBulkTicketObservability(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateXrayBulkTicketObservability(CreateXrayBulkTicketObservabilityBuilder builder,
            ApimodelsXRayBulkTicketObservabilityRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateXrayBulkTicketObservability(
            string namespace_,
            Model.ApimodelsXRayBulkTicketObservabilityRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/tickets/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsXRayBulkTicketObservabilityResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsXRayBulkTicketObservabilityResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsXRayBulkTicketObservabilityResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayBulkTicketObservabilityResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}