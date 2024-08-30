// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// generateInvoiceSummary
    ///
    /// Generate invoice summary.
    /// Other detail info:
    /// 
    ///   * Returns : query orders
    /// </summary>
    public class GenerateInvoiceSummary : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GenerateInvoiceSummaryBuilder Builder { get => new GenerateInvoiceSummaryBuilder(); }

        public class GenerateInvoiceSummaryBuilder
            : OperationBuilder<GenerateInvoiceSummaryBuilder>
        {





            internal GenerateInvoiceSummaryBuilder() { }






            public GenerateInvoiceSummary Build(
                string namespace_,
                string endTime,
                string feature,
                string itemId,
                GenerateInvoiceSummaryItemType itemType,
                string startTime
            )
            {
                GenerateInvoiceSummary op = new GenerateInvoiceSummary(this,
                    namespace_,
                    endTime,
                    feature,
                    itemId,
                    itemType,
                    startTime
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GenerateInvoiceSummary(GenerateInvoiceSummaryBuilder builder,
            string namespace_,
            string endTime,
            string feature,
            string itemId,
            GenerateInvoiceSummaryItemType itemType,
            string startTime
        )
        {
            PathParams["namespace"] = namespace_;

            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (feature is not null) QueryParams["feature"] = feature;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (startTime is not null) QueryParams["startTime"] = startTime;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GenerateInvoiceSummary(
            string namespace_,
            string endTime,
            string feature,
            string itemId,
            GenerateInvoiceSummaryItemType itemType,
            string startTime
        )
        {
            PathParams["namespace"] = namespace_;

            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (feature is not null) QueryParams["feature"] = feature;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (startTime is not null) QueryParams["startTime"] = startTime;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/invoice/summary";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.InvoiceSummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.InvoiceSummary>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.InvoiceSummary>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.InvoiceSummary>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GenerateInvoiceSummaryItemType : StringEnum<GenerateInvoiceSummaryItemType>
    {
        public static readonly GenerateInvoiceSummaryItemType APP
            = new GenerateInvoiceSummaryItemType("APP");

        public static readonly GenerateInvoiceSummaryItemType BUNDLE
            = new GenerateInvoiceSummaryItemType("BUNDLE");

        public static readonly GenerateInvoiceSummaryItemType CODE
            = new GenerateInvoiceSummaryItemType("CODE");

        public static readonly GenerateInvoiceSummaryItemType COINS
            = new GenerateInvoiceSummaryItemType("COINS");

        public static readonly GenerateInvoiceSummaryItemType EXTENSION
            = new GenerateInvoiceSummaryItemType("EXTENSION");

        public static readonly GenerateInvoiceSummaryItemType INGAMEITEM
            = new GenerateInvoiceSummaryItemType("INGAMEITEM");

        public static readonly GenerateInvoiceSummaryItemType LOOTBOX
            = new GenerateInvoiceSummaryItemType("LOOTBOX");

        public static readonly GenerateInvoiceSummaryItemType MEDIA
            = new GenerateInvoiceSummaryItemType("MEDIA");

        public static readonly GenerateInvoiceSummaryItemType OPTIONBOX
            = new GenerateInvoiceSummaryItemType("OPTIONBOX");

        public static readonly GenerateInvoiceSummaryItemType SEASON
            = new GenerateInvoiceSummaryItemType("SEASON");

        public static readonly GenerateInvoiceSummaryItemType SUBSCRIPTION
            = new GenerateInvoiceSummaryItemType("SUBSCRIPTION");


        public static implicit operator GenerateInvoiceSummaryItemType(string value)
        {
            return NewValue(value);
        }

        public GenerateInvoiceSummaryItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

}