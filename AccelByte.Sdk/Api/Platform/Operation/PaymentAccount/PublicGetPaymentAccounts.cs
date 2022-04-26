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
    /// publicGetPaymentAccounts
    ///
    /// Get payment accounts.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:PAYMENT:ACCOUNT", action=2 (READ)
    ///   *  Returns : Payment account list
    /// </summary>
    public class PublicGetPaymentAccounts : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPaymentAccountsBuilder Builder = new PublicGetPaymentAccountsBuilder();

        public class PublicGetPaymentAccountsBuilder
            : OperationBuilder<PublicGetPaymentAccountsBuilder>
        {
            
            
            internal PublicGetPaymentAccountsBuilder() { }






            public PublicGetPaymentAccounts Build(
                string namespace_,
                string userId
            )
            {
                PublicGetPaymentAccounts op = new PublicGetPaymentAccounts(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetPaymentAccounts(PublicGetPaymentAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetPaymentAccounts(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.PaymentAccount>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentAccount>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentAccount>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}