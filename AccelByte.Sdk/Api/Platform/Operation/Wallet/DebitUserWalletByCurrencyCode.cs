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
    /// debitUserWalletByCurrencyCode
    ///
    /// Debit a user wallet by currency code, default is debit system wallet.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:WALLET", action=4 (UPDATE)
    /// </summary>
    public class DebitUserWalletByCurrencyCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebitUserWalletByCurrencyCodeBuilder Builder { get => new DebitUserWalletByCurrencyCodeBuilder(); }

        public class DebitUserWalletByCurrencyCodeBuilder
            : OperationBuilder<DebitUserWalletByCurrencyCodeBuilder>
        {


            public Model.DebitByCurrencyCodeRequest? Body { get; set; }




            internal DebitUserWalletByCurrencyCodeBuilder() { }



            public DebitUserWalletByCurrencyCodeBuilder SetBody(Model.DebitByCurrencyCodeRequest _body)
            {
                Body = _body;
                return this;
            }




            public DebitUserWalletByCurrencyCode Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                DebitUserWalletByCurrencyCode op = new DebitUserWalletByCurrencyCode(this,
                    currencyCode,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DebitUserWalletByCurrencyCode(DebitUserWalletByCurrencyCodeBuilder builder,
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

        public DebitUserWalletByCurrencyCode(
            string currencyCode,
            string namespace_,
            string userId,
            Model.DebitByCurrencyCodeRequest body
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/{currencyCode}/debit";

        public override HttpMethod Method => HttpMethod.Put;

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