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
    /// downloadInvoiceDetails
    ///
    /// Download invoice details as a csv file.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ORDER", action=2 (READ)
    ///   *  Returns : invoice details csv file
    /// </summary>
    public class DownloadInvoiceDetails : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadInvoiceDetailsBuilder Builder = new DownloadInvoiceDetailsBuilder();

        public class DownloadInvoiceDetailsBuilder
            : OperationBuilder<DownloadInvoiceDetailsBuilder>
        {

            public string? Feature { get; set; }

            public string? ItemId { get; set; }

            public DownloadInvoiceDetailsItemType? ItemType { get; set; }





            internal DownloadInvoiceDetailsBuilder() { }


            public DownloadInvoiceDetailsBuilder SetFeature(string _feature)
            {
                Feature = _feature;
                return this;
            }

            public DownloadInvoiceDetailsBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public DownloadInvoiceDetailsBuilder SetItemType(DownloadInvoiceDetailsItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }





            public DownloadInvoiceDetails Build(
                string namespace_,
                string endTime,
                string startTime
            )
            {
                DownloadInvoiceDetails op = new DownloadInvoiceDetails(this,
                    namespace_,
                    endTime,
                    startTime
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DownloadInvoiceDetails(DownloadInvoiceDetailsBuilder builder,
            string namespace_,
            string endTime,
            string startTime
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Feature is not null) QueryParams["feature"] = builder.Feature;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (startTime is not null) QueryParams["startTime"] = startTime;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DownloadInvoiceDetails(
            string namespace_,
            string? feature,
            string? itemId,
            DownloadInvoiceDetailsItemType? itemType,
            string endTime,
            string startTime
        )
        {
            PathParams["namespace"] = namespace_;

            if (feature is not null) QueryParams["feature"] = feature;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (startTime is not null) QueryParams["startTime"] = startTime;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/invoice/details.csv";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "text/csv" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class DownloadInvoiceDetailsItemType : StringEnum<DownloadInvoiceDetailsItemType>
    {
        public static readonly DownloadInvoiceDetailsItemType APP
            = new DownloadInvoiceDetailsItemType("APP");

        public static readonly DownloadInvoiceDetailsItemType BUNDLE
            = new DownloadInvoiceDetailsItemType("BUNDLE");

        public static readonly DownloadInvoiceDetailsItemType CODE
            = new DownloadInvoiceDetailsItemType("CODE");

        public static readonly DownloadInvoiceDetailsItemType COINS
            = new DownloadInvoiceDetailsItemType("COINS");

        public static readonly DownloadInvoiceDetailsItemType EXTENSION
            = new DownloadInvoiceDetailsItemType("EXTENSION");

        public static readonly DownloadInvoiceDetailsItemType INGAMEITEM
            = new DownloadInvoiceDetailsItemType("INGAMEITEM");

        public static readonly DownloadInvoiceDetailsItemType MEDIA
            = new DownloadInvoiceDetailsItemType("MEDIA");

        public static readonly DownloadInvoiceDetailsItemType OPTIONBOX
            = new DownloadInvoiceDetailsItemType("OPTIONBOX");

        public static readonly DownloadInvoiceDetailsItemType SEASON
            = new DownloadInvoiceDetailsItemType("SEASON");

        public static readonly DownloadInvoiceDetailsItemType SUBSCRIPTION
            = new DownloadInvoiceDetailsItemType("SUBSCRIPTION");


        public static implicit operator DownloadInvoiceDetailsItemType(string value)
        {
            return NewValue(value);
        }

        public DownloadInvoiceDetailsItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

}