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
    /// getWallet
    ///
    /// get a wallet by wallet id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:WALLET", action=2 (READ)
    ///   *  Returns : wallet info
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetWalletBuilder Builder { get => new GetWalletBuilder(); }

        public class GetWalletBuilder
            : OperationBuilder<GetWalletBuilder>
        {





            internal GetWalletBuilder() { }






            public GetWallet Build(
                string namespace_,
                string walletId
            )
            {
                GetWallet op = new GetWallet(this,
                    namespace_,                    
                    walletId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetWallet(GetWalletBuilder builder,
            string namespace_,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["walletId"] = walletId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetWallet(
            string namespace_,            
            string walletId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["walletId"] = walletId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/wallets/{walletId}";

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