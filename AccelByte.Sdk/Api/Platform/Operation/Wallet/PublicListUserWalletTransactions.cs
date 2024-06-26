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
    /// publicListUserWalletTransactions
    ///
    /// List wallet transactions by currency code ordered by create time desc.
    /// Other detail info:
    /// 
    ///   * Returns : currency transaction info
    /// </summary>
    public class PublicListUserWalletTransactions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserWalletTransactionsBuilder Builder { get => new PublicListUserWalletTransactionsBuilder(); }

        public class PublicListUserWalletTransactionsBuilder
            : OperationBuilder<PublicListUserWalletTransactionsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal PublicListUserWalletTransactionsBuilder() { }


            public PublicListUserWalletTransactionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListUserWalletTransactionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public PublicListUserWalletTransactions Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PublicListUserWalletTransactions op = new PublicListUserWalletTransactions(this,
                    currencyCode,
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

        private PublicListUserWalletTransactions(PublicListUserWalletTransactionsBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListUserWalletTransactions(
            string currencyCode,
            string namespace_,
            string userId,
            int? limit,
            int? offset
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/transactions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.WalletTransactionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.WalletTransactionPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.WalletTransactionPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.WalletTransactionPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}