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
    /// getPaymentTaxConfig
    ///
    ///  [Not Supported Yet In Starter] Get payment global tax config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment provider list
    /// </summary>
    public class GetPaymentTaxConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentTaxConfigBuilder Builder { get => new GetPaymentTaxConfigBuilder(); }

        public class GetPaymentTaxConfigBuilder
            : OperationBuilder<GetPaymentTaxConfigBuilder>
        {





            internal GetPaymentTaxConfigBuilder() { }






            public GetPaymentTaxConfig Build(
            )
            {
                GetPaymentTaxConfig op = new GetPaymentTaxConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetPaymentTaxConfig(GetPaymentTaxConfigBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPaymentTaxConfig(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/tax";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.PaymentTaxConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}