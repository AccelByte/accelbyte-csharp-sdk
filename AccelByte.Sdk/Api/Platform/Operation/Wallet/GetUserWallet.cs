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
    /// getUserWallet
    ///
    /// get a user wallet.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:WALLET", action=2 (READ)
    ///   *  Returns : wallet info
    /// </summary>
    public class GetUserWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserWalletBuilder Builder = new GetUserWalletBuilder();

        public class GetUserWalletBuilder
        {
            
            
            
            internal GetUserWalletBuilder() { }





            public GetUserWallet Build(
                string namespace_,
                string userId,
                string walletId
            )
            {
                return new GetUserWallet(this,
                    namespace_,                    
                    userId,                    
                    walletId                    
                );
            }
        }

        private GetUserWallet(GetUserWalletBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;
            
            
            
            
            
        }
        #endregion

        public GetUserWallet(
            string namespace_,            
            string userId,            
            string walletId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.WalletInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.WalletInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.WalletInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}