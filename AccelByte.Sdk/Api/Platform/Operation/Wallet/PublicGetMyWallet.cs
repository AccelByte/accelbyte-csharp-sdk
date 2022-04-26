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
    /// publicGetMyWallet
    ///
    /// get my wallet by currency code and namespace.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:WALLET", action=2 (READ)
    ///   *  Returns : wallet info
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to get publisher user wallet
    ///     * can be filled with game namespace in order to get game user wallet
    /// </summary>
    public class PublicGetMyWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyWalletBuilder Builder = new PublicGetMyWalletBuilder();

        public class PublicGetMyWalletBuilder
            : OperationBuilder<PublicGetMyWalletBuilder>
        {
            
            
            internal PublicGetMyWalletBuilder() { }






            public PublicGetMyWallet Build(
                string currencyCode,
                string namespace_
            )
            {
                PublicGetMyWallet op = new PublicGetMyWallet(this,
                    currencyCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetMyWallet(PublicGetMyWalletBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetMyWallet(
            string currencyCode,            
            string namespace_            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/wallets/{currencyCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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