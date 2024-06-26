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
    /// adminQueryPartyDetail
    ///
    /// Get all parties.
    /// </summary>
    public class AdminQueryPartyDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryPartyDetailBuilder Builder { get => new AdminQueryPartyDetailBuilder(); }

        public class AdminQueryPartyDetailBuilder
            : OperationBuilder<AdminQueryPartyDetailBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? PartyID { get; set; }

            public string? UserID { get; set; }





            internal AdminQueryPartyDetailBuilder() { }


            public AdminQueryPartyDetailBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryPartyDetailBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryPartyDetailBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminQueryPartyDetailBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public AdminQueryPartyDetailBuilder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public AdminQueryPartyDetailBuilder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }





            public AdminQueryPartyDetail Build(
                string namespace_
            )
            {
                AdminQueryPartyDetail op = new AdminQueryPartyDetail(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminQueryPartyDetail(AdminQueryPartyDetailBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.PartyID is not null) QueryParams["partyID"] = builder.PartyID;
            if (builder.UserID is not null) QueryParams["userID"] = builder.UserID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryPartyDetail(
            string namespace_,
            long? limit,
            long? offset,
            string? order,
            string? orderBy,
            string? partyID,
            string? userID
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (partyID is not null) QueryParams["partyID"] = partyID;
            if (userID is not null) QueryParams["userID"] = userID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v1/admin/namespaces/{namespace}/parties";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsPartyDetailQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsPartyDetailQueryResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsPartyDetailQueryResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartyDetailQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}