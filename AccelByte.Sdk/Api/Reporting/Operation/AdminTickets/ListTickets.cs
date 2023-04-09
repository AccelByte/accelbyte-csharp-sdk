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
    /// listTickets
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:TICKET [READ]
    /// Tickets list can be ordered by:
    /// - createdAt
    /// - reportsCount
    /// - status (currently there are OPEN, AUTO_MODERATED and CLOSED statuses, desc order will put ticket with CLOSED status at the top)
    /// </summary>
    public class ListTickets : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListTicketsBuilder Builder { get => new ListTicketsBuilder(); }

        public class ListTicketsBuilder
            : OperationBuilder<ListTicketsBuilder>
        {

            public string? Category { get; set; }

            public string? ExtensionCategory { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? ReportedUserId { get; set; }

            public string? SortBy { get; set; }

            public string? Status { get; set; }





            internal ListTicketsBuilder() { }


            public ListTicketsBuilder SetCategory(string _category)
            {
                Category = _category;
                return this;
            }

            public ListTicketsBuilder SetExtensionCategory(string _extensionCategory)
            {
                ExtensionCategory = _extensionCategory;
                return this;
            }

            public ListTicketsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListTicketsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListTicketsBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public ListTicketsBuilder SetReportedUserId(string _reportedUserId)
            {
                ReportedUserId = _reportedUserId;
                return this;
            }

            public ListTicketsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public ListTicketsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public ListTickets Build(
                string namespace_
            )
            {
                ListTickets op = new ListTickets(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListTickets(ListTicketsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Category is not null) QueryParams["category"] = builder.Category;
            if (builder.ExtensionCategory is not null) QueryParams["extensionCategory"] = builder.ExtensionCategory;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.ReportedUserId is not null) QueryParams["reportedUserId"] = builder.ReportedUserId;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListTickets(
            string namespace_,
            string? category,
            string? extensionCategory,
            long? limit,
            long? offset,
            string? order,
            string? reportedUserId,
            string? sortBy,
            string? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (category is not null) QueryParams["category"] = category;
            if (extensionCategory is not null) QueryParams["extensionCategory"] = extensionCategory;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (reportedUserId is not null) QueryParams["reportedUserId"] = reportedUserId;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/tickets";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiTicketListResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiTicketListResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiTicketListResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}