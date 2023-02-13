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
    /// payWithUserWallet
    ///
    /// Pay with user wallet by currency code and client platform.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:WALLET", action=4 (UPDATE)
    /// </summary>
    public class PayWithUserWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PayWithUserWalletBuilder Builder { get => new PayWithUserWalletBuilder(); }

        public class PayWithUserWalletBuilder
            : OperationBuilder<PayWithUserWalletBuilder>
        {


            public Model.PaymentRequest? Body { get; set; }




            internal PayWithUserWalletBuilder() { }



            public PayWithUserWalletBuilder SetBody(Model.PaymentRequest _body)
            {
                Body = _body;
                return this;
            }




            public PayWithUserWallet Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PayWithUserWallet op = new PayWithUserWallet(this,
                    currencyCode,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PayWithUserWallet(PayWithUserWalletBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PayWithUserWallet(
            string currencyCode,
            string namespace_,
            string userId,
            Model.PaymentRequest body
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/payment";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.PlatformWallet? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PlatformWallet>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PlatformWallet>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}