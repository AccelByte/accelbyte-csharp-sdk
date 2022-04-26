// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    /// <summary>
    /// listAllTerminatedServers
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSLM:SERVER [READ]
    /// 
    /// This endpoint used to retrieve terminated servers in all namespace
    /// ```
    /// </summary>
    public class ListAllTerminatedServers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListAllTerminatedServersBuilder Builder = new ListAllTerminatedServersBuilder();

        public class ListAllTerminatedServersBuilder
            : OperationBuilder<ListAllTerminatedServersBuilder>
        {
            public string? Deployment { get; set; }
            
            public string? EndDate { get; set; }
            
            public string? GameMode { get; set; }
            
            public long? Limit { get; set; }
            
            public string? Namespace { get; set; }
            
            public string? Next { get; set; }
            
            public string? PartyId { get; set; }
            
            public string? PodName { get; set; }
            
            public string? Previous { get; set; }
            
            public string? Provider { get; set; }
            
            public string? Region { get; set; }
            
            public string? SessionId { get; set; }
            
            public string? StartDate { get; set; }
            
            public string? UserId { get; set; }
            
            internal ListAllTerminatedServersBuilder() { }


            public ListAllTerminatedServersBuilder SetDeployment(string _deployment)
            {
                Deployment = _deployment;
                return this;
            }

            public ListAllTerminatedServersBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public ListAllTerminatedServersBuilder SetGameMode(string _gameMode)
            {
                GameMode = _gameMode;
                return this;
            }

            public ListAllTerminatedServersBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListAllTerminatedServersBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public ListAllTerminatedServersBuilder SetNext(string _next)
            {
                Next = _next;
                return this;
            }

            public ListAllTerminatedServersBuilder SetPartyId(string _partyId)
            {
                PartyId = _partyId;
                return this;
            }

            public ListAllTerminatedServersBuilder SetPodName(string _podName)
            {
                PodName = _podName;
                return this;
            }

            public ListAllTerminatedServersBuilder SetPrevious(string _previous)
            {
                Previous = _previous;
                return this;
            }

            public ListAllTerminatedServersBuilder SetProvider(string _provider)
            {
                Provider = _provider;
                return this;
            }

            public ListAllTerminatedServersBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public ListAllTerminatedServersBuilder SetSessionId(string _sessionId)
            {
                SessionId = _sessionId;
                return this;
            }

            public ListAllTerminatedServersBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public ListAllTerminatedServersBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public ListAllTerminatedServers Build(
            )
            {
                ListAllTerminatedServers op = new ListAllTerminatedServers(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListAllTerminatedServers(ListAllTerminatedServersBuilder builder
        )
        {
            
            if (builder.Deployment != null) QueryParams["deployment"] = builder.Deployment;
            if (builder.EndDate != null) QueryParams["end_date"] = builder.EndDate;
            if (builder.GameMode != null) QueryParams["game_mode"] = builder.GameMode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Namespace != null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Next != null) QueryParams["next"] = builder.Next;
            if (builder.PartyId != null) QueryParams["party_id"] = builder.PartyId;
            if (builder.PodName != null) QueryParams["pod_name"] = builder.PodName;
            if (builder.Previous != null) QueryParams["previous"] = builder.Previous;
            if (builder.Provider != null) QueryParams["provider"] = builder.Provider;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.SessionId != null) QueryParams["session_id"] = builder.SessionId;
            if (builder.StartDate != null) QueryParams["start_date"] = builder.StartDate;
            if (builder.UserId != null) QueryParams["user_id"] = builder.UserId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListAllTerminatedServers(
            string? deployment,            
            string? endDate,            
            string? gameMode,            
            long? limit,            
            string? namespace_,            
            string? next,            
            string? partyId,            
            string? podName,            
            string? previous,            
            string? provider,            
            string? region,            
            string? sessionId,            
            string? startDate,            
            string? userId            
        )
        {
            
            if (deployment != null) QueryParams["deployment"] = deployment;
            if (endDate != null) QueryParams["end_date"] = endDate;
            if (gameMode != null) QueryParams["game_mode"] = gameMode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            if (next != null) QueryParams["next"] = next;
            if (partyId != null) QueryParams["party_id"] = partyId;
            if (podName != null) QueryParams["pod_name"] = podName;
            if (previous != null) QueryParams["previous"] = previous;
            if (provider != null) QueryParams["provider"] = provider;
            if (region != null) QueryParams["region"] = region;
            if (sessionId != null) QueryParams["session_id"] = sessionId;
            if (startDate != null) QueryParams["start_date"] = startDate;
            if (userId != null) QueryParams["user_id"] = userId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dslogmanager/servers/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
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