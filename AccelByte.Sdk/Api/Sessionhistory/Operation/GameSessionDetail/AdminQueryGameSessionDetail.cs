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
    /// adminQueryGameSessionDetail
    ///
    /// Get all game sessions.
    /// </summary>
    public class AdminQueryGameSessionDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryGameSessionDetailBuilder Builder { get => new AdminQueryGameSessionDetailBuilder(); }

        public class AdminQueryGameSessionDetailBuilder
            : OperationBuilder<AdminQueryGameSessionDetailBuilder>
        {

            public string? EndDate { get; set; }

            public string? GameSessionID { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? StartDate { get; set; }

            public string? UserID { get; set; }





            internal AdminQueryGameSessionDetailBuilder() { }


            public AdminQueryGameSessionDetailBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminQueryGameSessionDetailBuilder SetGameSessionID(string _gameSessionID)
            {
                GameSessionID = _gameSessionID;
                return this;
            }

            public AdminQueryGameSessionDetailBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryGameSessionDetailBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryGameSessionDetailBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminQueryGameSessionDetailBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public AdminQueryGameSessionDetailBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public AdminQueryGameSessionDetailBuilder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }





            public AdminQueryGameSessionDetail Build(
                string namespace_
            )
            {
                AdminQueryGameSessionDetail op = new AdminQueryGameSessionDetail(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminQueryGameSessionDetail(AdminQueryGameSessionDetailBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.GameSessionID is not null) QueryParams["gameSessionID"] = builder.GameSessionID;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (builder.UserID is not null) QueryParams["userID"] = builder.UserID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryGameSessionDetail(
            string namespace_,
            string? endDate,
            string? gameSessionID,
            long? limit,
            long? offset,
            string? order,
            string? orderBy,
            string? startDate,
            string? userID
        )
        {
            PathParams["namespace"] = namespace_;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (gameSessionID is not null) QueryParams["gameSessionID"] = gameSessionID;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (userID is not null) QueryParams["userID"] = userID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v1/admin/namespaces/{namespace}/gamesessions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsGameSessionDetailQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsGameSessionDetailQueryResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsGameSessionDetailQueryResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionDetailQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}