// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;
using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionhistoryXRay_OpExts
    {
        public static Sessionhistory.Model.ApimodelsXRayMatchPoolQueryResponse? Execute(
            this QueryXrayMatchPool.QueryXrayMatchPoolBuilder builder,
            string namespace_,
            List<string> poolName,
            string endDate,
            string startDate
        )
        {
            QueryXrayMatchPool op = builder.Build(
                namespace_,
                poolName,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayMatchPool(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchPoolQueryResponse?> ExecuteAsync(
            this QueryXrayMatchPool.QueryXrayMatchPoolBuilder builder,
            string namespace_,
            List<string> poolName,
            string endDate,
            string startDate
        )
        {
            QueryXrayMatchPool op = builder.Build(
                namespace_,
                poolName,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayMatchPoolAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchPoolPodTickQueryResponse? Execute(
            this QueryDetailTickMatchPool.QueryDetailTickMatchPoolBuilder builder,
            string namespace_,
            string podName,
            string poolName,
            string endDate,
            string startDate
        )
        {
            QueryDetailTickMatchPool op = builder.Build(
                namespace_,
                podName,
                poolName,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryDetailTickMatchPool(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchPoolPodTickQueryResponse?> ExecuteAsync(
            this QueryDetailTickMatchPool.QueryDetailTickMatchPoolBuilder builder,
            string namespace_,
            string podName,
            string poolName,
            string endDate,
            string startDate
        )
        {
            QueryDetailTickMatchPool op = builder.Build(
                namespace_,
                podName,
                poolName,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryDetailTickMatchPoolAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchPoolPodTickMatchResponse? Execute(
            this QueryDetailTickMatchPoolMatches.QueryDetailTickMatchPoolMatchesBuilder builder,
            string namespace_,
            string podName,
            string poolName,
            string tickId
        )
        {
            QueryDetailTickMatchPoolMatches op = builder.Build(
                namespace_,
                podName,
                poolName,
                tickId
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryDetailTickMatchPoolMatches(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchPoolPodTickMatchResponse?> ExecuteAsync(
            this QueryDetailTickMatchPoolMatches.QueryDetailTickMatchPoolMatchesBuilder builder,
            string namespace_,
            string podName,
            string poolName,
            string tickId
        )
        {
            QueryDetailTickMatchPoolMatches op = builder.Build(
                namespace_,
                podName,
                poolName,
                tickId
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryDetailTickMatchPoolMatchesAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchPoolPodTickTicketResponse? Execute(
            this QueryDetailTickMatchPoolTicket.QueryDetailTickMatchPoolTicketBuilder builder,
            string namespace_,
            string podName,
            string poolName,
            string tickId
        )
        {
            QueryDetailTickMatchPoolTicket op = builder.Build(
                namespace_,
                podName,
                poolName,
                tickId
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryDetailTickMatchPoolTicket(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchPoolPodTickTicketResponse?> ExecuteAsync(
            this QueryDetailTickMatchPoolTicket.QueryDetailTickMatchPoolTicketBuilder builder,
            string namespace_,
            string podName,
            string poolName,
            string tickId
        )
        {
            QueryDetailTickMatchPoolTicket op = builder.Build(
                namespace_,
                podName,
                poolName,
                tickId
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryDetailTickMatchPoolTicketAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchHistorQueryResponse? Execute(
            this QueryMatchHistories.QueryMatchHistoriesBuilder builder,
            string matchId,
            string namespace_
        )
        {
            QueryMatchHistories op = builder.Build(
                matchId,
                namespace_
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchHistories(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchHistorQueryResponse?> ExecuteAsync(
            this QueryMatchHistories.QueryMatchHistoriesBuilder builder,
            string matchId,
            string namespace_
        )
        {
            QueryMatchHistories op = builder.Build(
                matchId,
                namespace_
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchHistoriesAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchTicketHistoryQueryResponse? Execute(
            this QueryMatchTicketHistories.QueryMatchTicketHistoriesBuilder builder,
            string matchId,
            string namespace_
        )
        {
            QueryMatchTicketHistories op = builder.Build(
                matchId,
                namespace_
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchTicketHistories(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchTicketHistoryQueryResponse?> ExecuteAsync(
            this QueryMatchTicketHistories.QueryMatchTicketHistoriesBuilder builder,
            string matchId,
            string namespace_
        )
        {
            QueryMatchTicketHistories op = builder.Build(
                matchId,
                namespace_
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchTicketHistoriesAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchesQueryResponse? Execute(
            this QueryXrayMatch.QueryXrayMatchBuilder builder,
            string matchId,
            string namespace_
        )
        {
            QueryXrayMatch op = builder.Build(
                matchId,
                namespace_
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayMatch(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchesQueryResponse?> ExecuteAsync(
            this QueryXrayMatch.QueryXrayMatchBuilder builder,
            string matchId,
            string namespace_
        )
        {
            QueryXrayMatch op = builder.Build(
                matchId,
                namespace_
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayMatchAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayAcquiringDsQueryResponse? Execute(
            this QueryAcquiringDS.QueryAcquiringDSBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryAcquiringDS op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryAcquiringDS(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayAcquiringDsQueryResponse?> ExecuteAsync(
            this QueryAcquiringDS.QueryAcquiringDSBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryAcquiringDS op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryAcquiringDSAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayAcquiringDsWaitTimeQueryResponse? Execute(
            this QueryAcquiringDSWaitTimeAvg.QueryAcquiringDSWaitTimeAvgBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryAcquiringDSWaitTimeAvg op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryAcquiringDSWaitTimeAvg(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayAcquiringDsWaitTimeQueryResponse?> ExecuteAsync(
            this QueryAcquiringDSWaitTimeAvg.QueryAcquiringDSWaitTimeAvgBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryAcquiringDSWaitTimeAvg op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryAcquiringDSWaitTimeAvgAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchLengthDurationQueryResponse? Execute(
            this QueryMatchLengthDurationpAvg.QueryMatchLengthDurationpAvgBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryMatchLengthDurationpAvg op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchLengthDurationpAvg(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchLengthDurationQueryResponse?> ExecuteAsync(
            this QueryMatchLengthDurationpAvg.QueryMatchLengthDurationpAvgBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryMatchLengthDurationpAvg op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchLengthDurationpAvgAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchLengthDurationQueryResponse? Execute(
            this QueryMatchLengthDurationp99.QueryMatchLengthDurationp99Builder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryMatchLengthDurationp99 op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchLengthDurationp99(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchLengthDurationQueryResponse?> ExecuteAsync(
            this QueryMatchLengthDurationp99.QueryMatchLengthDurationp99Builder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryMatchLengthDurationp99 op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryMatchLengthDurationp99Async(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayTotalActiveSessionQueryResponse? Execute(
            this QueryTotalActiveSession.QueryTotalActiveSessionBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalActiveSession op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalActiveSession(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayTotalActiveSessionQueryResponse?> ExecuteAsync(
            this QueryTotalActiveSession.QueryTotalActiveSessionBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalActiveSession op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalActiveSessionAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchMatchmakingQueryResponse? Execute(
            this QueryTotalMatchmakingMatch.QueryTotalMatchmakingMatchBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingMatch op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingMatch(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchMatchmakingQueryResponse?> ExecuteAsync(
            this QueryTotalMatchmakingMatch.QueryTotalMatchmakingMatchBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingMatch op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingMatchAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayTotalPlayerPersessionAVGQueryResponse? Execute(
            this QueryTotalPlayerPersession.QueryTotalPlayerPersessionBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalPlayerPersession op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalPlayerPersession(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayTotalPlayerPersessionAVGQueryResponse?> ExecuteAsync(
            this QueryTotalPlayerPersession.QueryTotalPlayerPersessionBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalPlayerPersession op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalPlayerPersessionAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayCanceledMatchmakingTicketQueryResponse? Execute(
            this QueryTotalMatchmakingCanceled.QueryTotalMatchmakingCanceledBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingCanceled op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingCanceled(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayCanceledMatchmakingTicketQueryResponse?> ExecuteAsync(
            this QueryTotalMatchmakingCanceled.QueryTotalMatchmakingCanceledBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingCanceled op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingCanceledAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayCreatedMatchmakingTicketQueryResponse? Execute(
            this QueryTotalMatchmakingCreated.QueryTotalMatchmakingCreatedBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingCreated op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingCreated(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayCreatedMatchmakingTicketQueryResponse?> ExecuteAsync(
            this QueryTotalMatchmakingCreated.QueryTotalMatchmakingCreatedBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingCreated op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingCreatedAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse? Execute(
            this QueryTotalMatchmakingExpired.QueryTotalMatchmakingExpiredBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingExpired op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingExpired(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse?> ExecuteAsync(
            this QueryTotalMatchmakingExpired.QueryTotalMatchmakingExpiredBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingExpired op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingExpiredAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayMatchMatchmakingTicketQueryResponse? Execute(
            this QueryTotalMatchmakingMatchTicket.QueryTotalMatchmakingMatchTicketBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingMatchTicket op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingMatchTicket(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayMatchMatchmakingTicketQueryResponse?> ExecuteAsync(
            this QueryTotalMatchmakingMatchTicket.QueryTotalMatchmakingMatchTicketBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            QueryTotalMatchmakingMatchTicket op = builder.Build(
                namespace_,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryTotalMatchmakingMatchTicketAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayTicketObservabilityResponse? Execute(
            this CreateXrayTicketObservability.CreateXrayTicketObservabilityBuilder builder,
            ApimodelsXRayTicketObservabilityRequest body,
            string namespace_
        )
        {
            CreateXrayTicketObservability op = builder.Build(
                body,
                namespace_
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).CreateXrayTicketObservability(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayTicketObservabilityResponse?> ExecuteAsync(
            this CreateXrayTicketObservability.CreateXrayTicketObservabilityBuilder builder,
            ApimodelsXRayTicketObservabilityRequest body,
            string namespace_
        )
        {
            CreateXrayTicketObservability op = builder.Build(
                body,
                namespace_
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).CreateXrayTicketObservabilityAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayBulkTicketObservabilityResponse? Execute(
            this CreateXrayBulkTicketObservability.CreateXrayBulkTicketObservabilityBuilder builder,
            ApimodelsXRayBulkTicketObservabilityRequest body,
            string namespace_
        )
        {
            CreateXrayBulkTicketObservability op = builder.Build(
                body,
                namespace_
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).CreateXrayBulkTicketObservability(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayBulkTicketObservabilityResponse?> ExecuteAsync(
            this CreateXrayBulkTicketObservability.CreateXrayBulkTicketObservabilityBuilder builder,
            ApimodelsXRayBulkTicketObservabilityRequest body,
            string namespace_
        )
        {
            CreateXrayBulkTicketObservability op = builder.Build(
                body,
                namespace_
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).CreateXrayBulkTicketObservabilityAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayTicketQueryResponse? Execute(
            this QueryXrayTimelineByTicketID.QueryXrayTimelineByTicketIDBuilder builder,
            string namespace_,
            string ticketId,
            string endDate,
            string startDate
        )
        {
            QueryXrayTimelineByTicketID op = builder.Build(
                namespace_,
                ticketId,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayTimelineByTicketID(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayTicketQueryResponse?> ExecuteAsync(
            this QueryXrayTimelineByTicketID.QueryXrayTimelineByTicketIDBuilder builder,
            string namespace_,
            string ticketId,
            string endDate,
            string startDate
        )
        {
            QueryXrayTimelineByTicketID op = builder.Build(
                namespace_,
                ticketId,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayTimelineByTicketIDAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsXRayTicketQueryResponse? Execute(
            this QueryXrayTimelineByUserID.QueryXrayTimelineByUserIDBuilder builder,
            string namespace_,
            string userId,
            string endDate,
            string startDate
        )
        {
            QueryXrayTimelineByUserID op = builder.Build(
                namespace_,
                userId,
                endDate,
                startDate
            );

            return ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayTimelineByUserID(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsXRayTicketQueryResponse?> ExecuteAsync(
            this QueryXrayTimelineByUserID.QueryXrayTimelineByUserIDBuilder builder,
            string namespace_,
            string userId,
            string endDate,
            string startDate
        )
        {
            QueryXrayTimelineByUserID op = builder.Build(
                namespace_,
                userId,
                endDate,
                startDate
            );

            return await ((Sessionhistory.Wrapper.XRay)builder.WrapperObject!).QueryXrayTimelineByUserIDAsync(op);
        }
    }
}