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
    /// updateXsollaUIConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Update xsolla UI configuration.Reference: [Xsolla Document](https://developers.xsolla.com/api.html#ui-integrations).
    /// Other detail info:
    /// 
    ///   * Returns : updated payment merchant config
    /// </summary>
    public class UpdateXsollaUIConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXsollaUIConfigBuilder Builder { get => new UpdateXsollaUIConfigBuilder(); }

        public class UpdateXsollaUIConfigBuilder
            : OperationBuilder<UpdateXsollaUIConfigBuilder>
        {





            internal UpdateXsollaUIConfigBuilder() { }






            public UpdateXsollaUIConfig Build(
                XsollaPaywallConfigRequest body,
                string id
            )
            {
                UpdateXsollaUIConfig op = new UpdateXsollaUIConfig(this,
                    body,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateXsollaUIConfig(UpdateXsollaUIConfigBuilder builder,
            XsollaPaywallConfigRequest body,
            string id
        )
        {
            PathParams["id"] = id;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateXsollaUIConfig(
            string id,
            Model.XsollaPaywallConfigRequest body
        )
        {
            PathParams["id"] = id;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/xsollauiconfig";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.PaymentMerchantConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}