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
    /// updatePaymentDomainWhitelistConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Update payment provider config by namespace.
    /// 
    /// 
    /// 
    ///      Request Body Parameters:
    /// 
    /// 
    ///      Parameter | Type   | Required | Description
    ///     -----------|--------|----------|--------------------------------------------------
    ///     domains    | String | Yes      | list of domains to whitelist for the return URL.
    /// 
    /// 
    /// 
    /// Other detail info:
    /// 
    ///   * Validation : the domain should include the protocol (http/https), but the whitelist check will only compare the host part (www.example.com)
    ///   *  Returns : payment domain whitelist config
    /// </summary>
    public class UpdatePaymentDomainWhitelistConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePaymentDomainWhitelistConfigBuilder Builder { get => new UpdatePaymentDomainWhitelistConfigBuilder(); }

        public class UpdatePaymentDomainWhitelistConfigBuilder
            : OperationBuilder<UpdatePaymentDomainWhitelistConfigBuilder>
        {





            internal UpdatePaymentDomainWhitelistConfigBuilder() { }






            public UpdatePaymentDomainWhitelistConfig Build(
                PaymentDomainWhitelistConfigEdit body,
                string namespace_
            )
            {
                UpdatePaymentDomainWhitelistConfig op = new UpdatePaymentDomainWhitelistConfig(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdatePaymentDomainWhitelistConfig(UpdatePaymentDomainWhitelistConfigBuilder builder,
            PaymentDomainWhitelistConfigEdit body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePaymentDomainWhitelistConfig(
            string namespace_,
            Model.PaymentDomainWhitelistConfigEdit body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/config/domains";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.PaymentDomainWhitelistConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.PaymentDomainWhitelistConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.PaymentDomainWhitelistConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentDomainWhitelistConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}