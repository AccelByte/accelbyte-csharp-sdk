// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:WALLET", action=2 (READ)
    ///   *  Returns : wallet transaction info
    /// </summary>
    public class PublicListUserWalletTransactions : AccelByte.Sdk.Core.Operation
    {
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
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/transactions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.WalletTransactionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.WalletTransactionPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.WalletTransactionPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}