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
    /// publicGetMyEntitlementOwnershipBySku
    ///
    /// Get my entitlement ownership by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Path's namespace :
    ///     * can be filled with publisher namespace in order to get publisher namespace entitlement ownership by sku
    ///     * can be filled with game namespace in order to get game namespace entitlement ownership by sku
    /// </summary>
    public class PublicGetMyEntitlementOwnershipBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyEntitlementOwnershipBySkuBuilder Builder { get => new PublicGetMyEntitlementOwnershipBySkuBuilder(); }

        public class PublicGetMyEntitlementOwnershipBySkuBuilder
            : OperationBuilder<PublicGetMyEntitlementOwnershipBySkuBuilder>
        {

            public PublicGetMyEntitlementOwnershipBySkuEntitlementClazz? EntitlementClazz { get; set; }





            internal PublicGetMyEntitlementOwnershipBySkuBuilder() { }


            public PublicGetMyEntitlementOwnershipBySkuBuilder SetEntitlementClazz(PublicGetMyEntitlementOwnershipBySkuEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public PublicGetMyEntitlementOwnershipBySku Build(
                string namespace_,
                string sku
            )
            {
                PublicGetMyEntitlementOwnershipBySku op = new PublicGetMyEntitlementOwnershipBySku(this,
                    namespace_,
                    sku
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetMyEntitlementOwnershipBySku(PublicGetMyEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetMyEntitlementOwnershipBySku(
            string namespace_,
            PublicGetMyEntitlementOwnershipBySkuEntitlementClazz? entitlementClazz,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;

            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.TimedOwnership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.TimedOwnership>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.TimedOwnership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicGetMyEntitlementOwnershipBySkuEntitlementClazz : StringEnum<PublicGetMyEntitlementOwnershipBySkuEntitlementClazz>
    {
        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz APP
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("APP");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz CODE
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("CODE");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz ENTITLEMENT
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("ENTITLEMENT");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz LOOTBOX
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("LOOTBOX");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz MEDIA
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("MEDIA");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz OPTIONBOX
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("OPTIONBOX");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz SUBSCRIPTION
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicGetMyEntitlementOwnershipBySkuEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicGetMyEntitlementOwnershipBySkuEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}