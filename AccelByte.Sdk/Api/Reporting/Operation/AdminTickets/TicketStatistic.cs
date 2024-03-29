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
    /// ticketStatistic
    ///
    /// Ticket statistic can be filtered by:
    /// - category
    /// - extension category
    /// </summary>
    public class TicketStatistic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TicketStatisticBuilder Builder { get => new TicketStatisticBuilder(); }

        public class TicketStatisticBuilder
            : OperationBuilder<TicketStatisticBuilder>
        {

            public string? ExtensionCategory { get; set; }





            internal TicketStatisticBuilder() { }


            public TicketStatisticBuilder SetExtensionCategory(string _extensionCategory)
            {
                ExtensionCategory = _extensionCategory;
                return this;
            }





            public TicketStatistic Build(
                string namespace_,
                string category
            )
            {
                TicketStatistic op = new TicketStatistic(this,
                    namespace_,
                    category
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private TicketStatistic(TicketStatisticBuilder builder,
            string namespace_,
            string category
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ExtensionCategory is not null) QueryParams["extensionCategory"] = builder.ExtensionCategory;
            if (category is not null) QueryParams["category"] = category;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TicketStatistic(
            string namespace_,
            string? extensionCategory,
            string category
        )
        {
            PathParams["namespace"] = namespace_;

            if (extensionCategory is not null) QueryParams["extensionCategory"] = extensionCategory;
            if (category is not null) QueryParams["category"] = category;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/tickets/statistic";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiTicketStatisticResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RestapiTicketStatisticResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RestapiTicketStatisticResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiTicketStatisticResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}