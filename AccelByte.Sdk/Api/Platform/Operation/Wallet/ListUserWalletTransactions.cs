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
    /// listUserWalletTransactions
    ///
    /// List user wallet transactions ordered by create time desc.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:WALLET", action=2 (READ)
    ///   *  Returns : wallet transaction info
    /// </summary>
    public class ListUserWalletTransactions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListUserWalletTransactionsBuilder Builder = new ListUserWalletTransactionsBuilder();

        public class ListUserWalletTransactionsBuilder
        {
            
            
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            internal ListUserWalletTransactionsBuilder() { }


            public ListUserWalletTransactionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListUserWalletTransactionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public ListUserWalletTransactions Build(
                string namespace_,
                string userId,
                string walletId
            )
            {
                return new ListUserWalletTransactions(this,
                    namespace_,                    
                    userId,                    
                    walletId                    
                );
            }
        }

        private ListUserWalletTransactions(ListUserWalletTransactionsBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public ListUserWalletTransactions(
            string namespace_,            
            string userId,            
            string walletId,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/transactions";

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