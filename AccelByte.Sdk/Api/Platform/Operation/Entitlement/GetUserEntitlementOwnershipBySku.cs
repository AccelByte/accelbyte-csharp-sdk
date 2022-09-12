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
    /// getUserEntitlementOwnershipBySku
    ///
    /// Get user entitlement ownership by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserEntitlementOwnershipBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementOwnershipBySkuBuilder Builder = new GetUserEntitlementOwnershipBySkuBuilder();

        public class GetUserEntitlementOwnershipBySkuBuilder
            : OperationBuilder<GetUserEntitlementOwnershipBySkuBuilder>
        {

            public GetUserEntitlementOwnershipBySkuEntitlementClazz? EntitlementClazz { get; set; }





            internal GetUserEntitlementOwnershipBySkuBuilder() { }


            public GetUserEntitlementOwnershipBySkuBuilder SetEntitlementClazz(GetUserEntitlementOwnershipBySkuEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public GetUserEntitlementOwnershipBySku Build(
                string namespace_,
                string userId,
                string sku
            )
            {
                GetUserEntitlementOwnershipBySku op = new GetUserEntitlementOwnershipBySku(this,
                    namespace_,
                    userId,
                    sku
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserEntitlementOwnershipBySku(GetUserEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserEntitlementOwnershipBySku(
            string namespace_,
            string userId,
            GetUserEntitlementOwnershipBySkuEntitlementClazz? entitlementClazz,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.TimedOwnership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetUserEntitlementOwnershipBySkuEntitlementClazz : StringEnum<GetUserEntitlementOwnershipBySkuEntitlementClazz>
    {
        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz APP
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("APP");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz CODE
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("CODE");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz ENTITLEMENT
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("ENTITLEMENT");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz MEDIA
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("MEDIA");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz OPTIONBOX
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("OPTIONBOX");

        public static readonly GetUserEntitlementOwnershipBySkuEntitlementClazz SUBSCRIPTION
            = new GetUserEntitlementOwnershipBySkuEntitlementClazz("SUBSCRIPTION");


        public static implicit operator GetUserEntitlementOwnershipBySkuEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public GetUserEntitlementOwnershipBySkuEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}