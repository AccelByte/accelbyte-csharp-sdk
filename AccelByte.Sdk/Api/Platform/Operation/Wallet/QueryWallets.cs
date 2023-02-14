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
    /// queryWallets
    ///
    /// Query wallets.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:WALLET", action=2 (READ)
    ///   *  Returns : paginated wallets info
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class QueryWallets : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryWalletsBuilder Builder { get => new QueryWalletsBuilder(); }

        public class QueryWalletsBuilder
            : OperationBuilder<QueryWalletsBuilder>
        {

            public string? CurrencyCode { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public QueryWalletsOrigin? Origin { get; set; }

            public string? UserId { get; set; }





            internal QueryWalletsBuilder() { }


            public QueryWalletsBuilder SetCurrencyCode(string _currencyCode)
            {
                CurrencyCode = _currencyCode;
                return this;
            }

            public QueryWalletsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryWalletsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryWalletsBuilder SetOrigin(QueryWalletsOrigin _origin)
            {
                Origin = _origin;
                return this;
            }

            public QueryWalletsBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QueryWallets Build(
                string namespace_
            )
            {
                QueryWallets op = new QueryWallets(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryWallets(QueryWalletsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.CurrencyCode is not null) QueryParams["currencyCode"] = builder.CurrencyCode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Origin is not null) QueryParams["origin"] = builder.Origin.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryWallets(
            string namespace_,
            string? currencyCode,
            int? limit,
            int? offset,
            QueryWalletsOrigin? origin,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (currencyCode is not null) QueryParams["currencyCode"] = currencyCode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (origin is not null) QueryParams["origin"] = origin.Value;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/wallets";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.WalletPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.WalletPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.WalletPagingSlicedResult>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryWalletsOrigin : StringEnum<QueryWalletsOrigin>
    {
        public static readonly QueryWalletsOrigin Epic
            = new QueryWalletsOrigin("Epic");

        public static readonly QueryWalletsOrigin GooglePlay
            = new QueryWalletsOrigin("GooglePlay");

        public static readonly QueryWalletsOrigin IOS
            = new QueryWalletsOrigin("IOS");

        public static readonly QueryWalletsOrigin Nintendo
            = new QueryWalletsOrigin("Nintendo");

        public static readonly QueryWalletsOrigin Other
            = new QueryWalletsOrigin("Other");

        public static readonly QueryWalletsOrigin Playstation
            = new QueryWalletsOrigin("Playstation");

        public static readonly QueryWalletsOrigin Steam
            = new QueryWalletsOrigin("Steam");

        public static readonly QueryWalletsOrigin System
            = new QueryWalletsOrigin("System");

        public static readonly QueryWalletsOrigin Twitch
            = new QueryWalletsOrigin("Twitch");

        public static readonly QueryWalletsOrigin Xbox
            = new QueryWalletsOrigin("Xbox");


        public static implicit operator QueryWalletsOrigin(string value)
        {
            return NewValue(value);
        }

        public QueryWalletsOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }

}