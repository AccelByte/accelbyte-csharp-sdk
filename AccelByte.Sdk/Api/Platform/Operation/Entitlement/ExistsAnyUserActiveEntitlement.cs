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
    /// existsAnyUserActiveEntitlement
    ///
    /// Exists any user active entitlement of specified itemIds, skus and appIds
    /// </summary>
    public class ExistsAnyUserActiveEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExistsAnyUserActiveEntitlementBuilder Builder { get => new ExistsAnyUserActiveEntitlementBuilder(); }

        public class ExistsAnyUserActiveEntitlementBuilder
            : OperationBuilder<ExistsAnyUserActiveEntitlementBuilder>
        {

            public List<string>? AppIds { get; set; }

            public List<string>? ItemIds { get; set; }

            public string? Platform { get; set; }

            public List<string>? Skus { get; set; }





            internal ExistsAnyUserActiveEntitlementBuilder() { }


            public ExistsAnyUserActiveEntitlementBuilder SetAppIds(List<string> _appIds)
            {
                AppIds = _appIds;
                return this;
            }

            public ExistsAnyUserActiveEntitlementBuilder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public ExistsAnyUserActiveEntitlementBuilder SetPlatform(string _platform)
            {
                Platform = _platform;
                return this;
            }

            public ExistsAnyUserActiveEntitlementBuilder SetSkus(List<string> _skus)
            {
                Skus = _skus;
                return this;
            }





            public ExistsAnyUserActiveEntitlement Build(
                string namespace_,
                string userId
            )
            {
                ExistsAnyUserActiveEntitlement op = new ExistsAnyUserActiveEntitlement(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private ExistsAnyUserActiveEntitlement(ExistsAnyUserActiveEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.AppIds is not null) QueryParams["appIds"] = builder.AppIds;
            if (builder.ItemIds is not null) QueryParams["itemIds"] = builder.ItemIds;
            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform;
            if (builder.Skus is not null) QueryParams["skus"] = builder.Skus;



            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExistsAnyUserActiveEntitlement(
            string namespace_,
            string userId,
            List<string>? appIds,
            List<string>? itemIds,
            string? platform,
            List<string>? skus
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (appIds is not null) QueryParams["appIds"] = appIds;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            if (platform is not null) QueryParams["platform"] = platform;
            if (skus is not null) QueryParams["skus"] = skus;



            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/any";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}