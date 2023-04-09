// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    /// <summary>
    /// listTerminatedServers
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSLM:SERVER [READ]
    /// 
    /// This endpoint used to retrieve terminated servers in a namespace
    /// ```
    /// </summary>
    public class ListTerminatedServers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListTerminatedServersBuilder Builder { get => new ListTerminatedServersBuilder(); }

        public class ListTerminatedServersBuilder
            : OperationBuilder<ListTerminatedServersBuilder>
        {

            public string? Deployment { get; set; }

            public string? EndDate { get; set; }

            public string? GameMode { get; set; }

            public long? Limit { get; set; }

            public string? Next { get; set; }

            public string? PartyId { get; set; }

            public string? PodName { get; set; }

            public string? Previous { get; set; }

            public string? Provider { get; set; }

            public string? Region { get; set; }

            public string? SessionId { get; set; }

            public string? StartDate { get; set; }

            public string? Status { get; set; }

            public string? UserId { get; set; }





            internal ListTerminatedServersBuilder() { }


            public ListTerminatedServersBuilder SetDeployment(string _deployment)
            {
                Deployment = _deployment;
                return this;
            }

            public ListTerminatedServersBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public ListTerminatedServersBuilder SetGameMode(string _gameMode)
            {
                GameMode = _gameMode;
                return this;
            }

            public ListTerminatedServersBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListTerminatedServersBuilder SetNext(string _next)
            {
                Next = _next;
                return this;
            }

            public ListTerminatedServersBuilder SetPartyId(string _partyId)
            {
                PartyId = _partyId;
                return this;
            }

            public ListTerminatedServersBuilder SetPodName(string _podName)
            {
                PodName = _podName;
                return this;
            }

            public ListTerminatedServersBuilder SetPrevious(string _previous)
            {
                Previous = _previous;
                return this;
            }

            public ListTerminatedServersBuilder SetProvider(string _provider)
            {
                Provider = _provider;
                return this;
            }

            public ListTerminatedServersBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public ListTerminatedServersBuilder SetSessionId(string _sessionId)
            {
                SessionId = _sessionId;
                return this;
            }

            public ListTerminatedServersBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public ListTerminatedServersBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public ListTerminatedServersBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public ListTerminatedServers Build(
                string namespace_
            )
            {
                ListTerminatedServers op = new ListTerminatedServers(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListTerminatedServers(ListTerminatedServersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Deployment is not null) QueryParams["deployment"] = builder.Deployment;
            if (builder.EndDate is not null) QueryParams["end_date"] = builder.EndDate;
            if (builder.GameMode is not null) QueryParams["game_mode"] = builder.GameMode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Next is not null) QueryParams["next"] = builder.Next;
            if (builder.PartyId is not null) QueryParams["party_id"] = builder.PartyId;
            if (builder.PodName is not null) QueryParams["pod_name"] = builder.PodName;
            if (builder.Previous is not null) QueryParams["previous"] = builder.Previous;
            if (builder.Provider is not null) QueryParams["provider"] = builder.Provider;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.SessionId is not null) QueryParams["session_id"] = builder.SessionId;
            if (builder.StartDate is not null) QueryParams["start_date"] = builder.StartDate;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            if (builder.UserId is not null) QueryParams["user_id"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListTerminatedServers(
            string namespace_,
            string? deployment,
            string? endDate,
            string? gameMode,
            long? limit,
            string? next,
            string? partyId,
            string? podName,
            string? previous,
            string? provider,
            string? region,
            string? sessionId,
            string? startDate,
            string? status,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (deployment is not null) QueryParams["deployment"] = deployment;
            if (endDate is not null) QueryParams["end_date"] = endDate;
            if (gameMode is not null) QueryParams["game_mode"] = gameMode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (next is not null) QueryParams["next"] = next;
            if (partyId is not null) QueryParams["party_id"] = partyId;
            if (podName is not null) QueryParams["pod_name"] = podName;
            if (previous is not null) QueryParams["previous"] = previous;
            if (provider is not null) QueryParams["provider"] = provider;
            if (region is not null) QueryParams["region"] = region;
            if (sessionId is not null) QueryParams["session_id"] = sessionId;
            if (startDate is not null) QueryParams["start_date"] = startDate;
            if (status is not null) QueryParams["status"] = status;
            if (userId is not null) QueryParams["user_id"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dslogmanager/namespaces/{namespace}/servers/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json", "text/x-log" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListTerminatedServersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListTerminatedServersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListTerminatedServersResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}