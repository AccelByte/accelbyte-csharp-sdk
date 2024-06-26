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
    /// publicUserEntitlementHistory
    ///
    /// Get user entitlement history
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : user entitlement history list
    /// </summary>
    public class PublicUserEntitlementHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUserEntitlementHistoryBuilder Builder { get => new PublicUserEntitlementHistoryBuilder(); }

        public class PublicUserEntitlementHistoryBuilder
            : OperationBuilder<PublicUserEntitlementHistoryBuilder>
        {

            public string? EndDate { get; set; }

            public PublicUserEntitlementHistoryEntitlementClazz? EntitlementClazz { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? StartDate { get; set; }





            internal PublicUserEntitlementHistoryBuilder() { }


            public PublicUserEntitlementHistoryBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public PublicUserEntitlementHistoryBuilder SetEntitlementClazz(PublicUserEntitlementHistoryEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }

            public PublicUserEntitlementHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicUserEntitlementHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicUserEntitlementHistoryBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }





            public PublicUserEntitlementHistory Build(
                string namespace_,
                string userId
            )
            {
                PublicUserEntitlementHistory op = new PublicUserEntitlementHistory(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicUserEntitlementHistory(PublicUserEntitlementHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUserEntitlementHistory(
            string namespace_,
            string userId,
            string? endDate,
            PublicUserEntitlementHistoryEntitlementClazz? entitlementClazz,
            int? limit,
            int? offset,
            string? startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.UserEntitlementHistoryPagingSlicedResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.UserEntitlementHistoryPagingSlicedResult>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.UserEntitlementHistoryPagingSlicedResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserEntitlementHistoryPagingSlicedResult>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicUserEntitlementHistoryEntitlementClazz : StringEnum<PublicUserEntitlementHistoryEntitlementClazz>
    {
        public static readonly PublicUserEntitlementHistoryEntitlementClazz APP
            = new PublicUserEntitlementHistoryEntitlementClazz("APP");

        public static readonly PublicUserEntitlementHistoryEntitlementClazz CODE
            = new PublicUserEntitlementHistoryEntitlementClazz("CODE");

        public static readonly PublicUserEntitlementHistoryEntitlementClazz ENTITLEMENT
            = new PublicUserEntitlementHistoryEntitlementClazz("ENTITLEMENT");

        public static readonly PublicUserEntitlementHistoryEntitlementClazz LOOTBOX
            = new PublicUserEntitlementHistoryEntitlementClazz("LOOTBOX");

        public static readonly PublicUserEntitlementHistoryEntitlementClazz MEDIA
            = new PublicUserEntitlementHistoryEntitlementClazz("MEDIA");

        public static readonly PublicUserEntitlementHistoryEntitlementClazz OPTIONBOX
            = new PublicUserEntitlementHistoryEntitlementClazz("OPTIONBOX");

        public static readonly PublicUserEntitlementHistoryEntitlementClazz SUBSCRIPTION
            = new PublicUserEntitlementHistoryEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicUserEntitlementHistoryEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicUserEntitlementHistoryEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}