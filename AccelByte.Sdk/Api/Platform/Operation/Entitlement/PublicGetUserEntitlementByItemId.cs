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
    /// publicGetUserEntitlementByItemId
    ///
    /// Get user entitlement by itemId.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetUserEntitlementByItemId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserEntitlementByItemIdBuilder Builder { get => new PublicGetUserEntitlementByItemIdBuilder(); }

        public class PublicGetUserEntitlementByItemIdBuilder
            : OperationBuilder<PublicGetUserEntitlementByItemIdBuilder>
        {

            public PublicGetUserEntitlementByItemIdEntitlementClazz? EntitlementClazz { get; set; }





            internal PublicGetUserEntitlementByItemIdBuilder() { }


            public PublicGetUserEntitlementByItemIdBuilder SetEntitlementClazz(PublicGetUserEntitlementByItemIdEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public PublicGetUserEntitlementByItemId Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementByItemId op = new PublicGetUserEntitlementByItemId(this,
                    namespace_,
                    userId,
                    itemId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetUserEntitlementByItemId(PublicGetUserEntitlementByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserEntitlementByItemId(
            string namespace_,
            string userId,
            PublicGetUserEntitlementByItemIdEntitlementClazz? entitlementClazz,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicGetUserEntitlementByItemIdEntitlementClazz : StringEnum<PublicGetUserEntitlementByItemIdEntitlementClazz>
    {
        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz APP
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("APP");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz CODE
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("CODE");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz ENTITLEMENT
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("ENTITLEMENT");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz LOOTBOX
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("LOOTBOX");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz MEDIA
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("MEDIA");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz OPTIONBOX
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("OPTIONBOX");

        public static readonly PublicGetUserEntitlementByItemIdEntitlementClazz SUBSCRIPTION
            = new PublicGetUserEntitlementByItemIdEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicGetUserEntitlementByItemIdEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicGetUserEntitlementByItemIdEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}