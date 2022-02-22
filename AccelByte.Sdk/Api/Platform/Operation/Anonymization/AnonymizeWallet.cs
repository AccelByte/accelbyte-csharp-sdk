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
    /// anonymizeWallet
    ///
    /// Anonymize wallet. At current it will only anonymize wallet, wallet transaction.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ANONYMIZATION", action=8 (DELETE)
    /// </summary>
    public class AnonymizeWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AnonymizeWalletBuilder Builder = new AnonymizeWalletBuilder();

        public class AnonymizeWalletBuilder
        {
            
            
            internal AnonymizeWalletBuilder() { }





            public AnonymizeWallet Build(
                string namespace_,
                string userId
            )
            {
                return new AnonymizeWallet(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AnonymizeWallet(AnonymizeWalletBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AnonymizeWallet(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/wallets";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}