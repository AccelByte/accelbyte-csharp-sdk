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
    /// publicGetItemByAppId
    ///
    /// This API is used to get item by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : the item with that appId
    /// </summary>
    public class PublicGetItemByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetItemByAppIdBuilder Builder { get => new PublicGetItemByAppIdBuilder(); }

        public class PublicGetItemByAppIdBuilder
            : OperationBuilder<PublicGetItemByAppIdBuilder>
        {

            public string? Language { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal PublicGetItemByAppIdBuilder() { }


            public PublicGetItemByAppIdBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetItemByAppIdBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicGetItemByAppIdBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicGetItemByAppId Build(
                string namespace_,
                string appId
            )
            {
                PublicGetItemByAppId op = new PublicGetItemByAppId(this,
                    namespace_,
                    appId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetItemByAppId(PublicGetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (appId is not null) QueryParams["appId"] = appId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetItemByAppId(
            string namespace_,
            string? language,
            string? region,
            string? storeId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;

            if (language is not null) QueryParams["language"] = language;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (appId is not null) QueryParams["appId"] = appId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ItemInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ItemInfo<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}