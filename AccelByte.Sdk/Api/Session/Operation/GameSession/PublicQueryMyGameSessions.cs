// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicQueryMyGameSessions
    ///
    /// Query user's game sessions.
    /// By default, API will return a list of user's active game sessions (INVITED,JOINED,CONNECTED).
    /// 
    /// Session service has several DSInformation status to track DS request to DS providers:
    /// - NEED_TO_REQUEST: number of active players hasn't reached session's minPlayers therefore DS has not yet requested.
    /// - REQUESTED: DS is being requested to DSMC.
    /// - PREPARING: DS needs to call manual set ready for the game session
    /// - AVAILABLE: DS is ready to use. The DSMC status for this DS is either READY/BUSY.
    /// - FAILED_TO_REQUEST: DSMC fails to spin up a DS for session.
    /// - DS_ERROR: DS provider fails to spin up the DS or the DS itself becomes unreachable
    /// - DS_CANCELLED: when DSMC is preparing the DS, DSMC will give a temporary DS. In this phase, if you delete the game session, the DS request will be canceled.
    /// - ENDED: when a game session (match) has finished and DS has done its job, it will terminate itself.
    /// - UNKNOWN: if any unknown DS status is detected.
    /// DSInformation has 2 fields for DS status: "status" and "statusV2". The "status" is there for backward-compatibility, therefore we encourage to just rely on "statusV2" for the more updated statuses.
    /// DS Source can be DSMC, AMS or custom. In DSMC, a DS request will be put in queue if they dont have available buffers, and DSMC will let the service knows when they finished spinning it up. While AMS doesn't have a concept of queue. Therefore some "DSInformation.statusV2" only applicable for DSMC.
    /// </summary>
    public class PublicQueryMyGameSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryMyGameSessionsBuilder Builder { get => new PublicQueryMyGameSessionsBuilder(); }

        public class PublicQueryMyGameSessionsBuilder
            : OperationBuilder<PublicQueryMyGameSessionsBuilder>
        {

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? Status { get; set; }





            internal PublicQueryMyGameSessionsBuilder() { }


            public PublicQueryMyGameSessionsBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public PublicQueryMyGameSessionsBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public PublicQueryMyGameSessionsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public PublicQueryMyGameSessions Build(
                string namespace_
            )
            {
                PublicQueryMyGameSessions op = new PublicQueryMyGameSessions(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicQueryMyGameSessions(PublicQueryMyGameSessionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryMyGameSessions(
            string namespace_,
            string? order,
            string? orderBy,
            string? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (status is not null) QueryParams["status"] = status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/users/me/gamesessions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsGameSessionQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}