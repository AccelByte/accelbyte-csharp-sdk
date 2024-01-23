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
    /// getBulkItemIdBySkus
    ///
    /// This API is used to get an list of itemId by list of sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : item data
    /// </summary>
    public class GetBulkItemIdBySkus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetBulkItemIdBySkusBuilder Builder { get => new GetBulkItemIdBySkusBuilder(); }

        public class GetBulkItemIdBySkusBuilder
            : OperationBuilder<GetBulkItemIdBySkusBuilder>
        {

            public List<string>? Sku { get; set; }

            public string? StoreId { get; set; }





            internal GetBulkItemIdBySkusBuilder() { }


            public GetBulkItemIdBySkusBuilder SetSku(List<string> _sku)
            {
                Sku = _sku;
                return this;
            }

            public GetBulkItemIdBySkusBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetBulkItemIdBySkus Build(
                string namespace_
            )
            {
                GetBulkItemIdBySkus op = new GetBulkItemIdBySkus(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetBulkItemIdBySkus(GetBulkItemIdBySkusBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Sku is not null) QueryParams["sku"] = builder.Sku;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;



            CollectionFormatMap["sku"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetBulkItemIdBySkus(
            string namespace_,
            List<string>? sku,
            string? storeId
        )
        {
            PathParams["namespace"] = namespace_;

            if (sku is not null) QueryParams["sku"] = sku;
            if (storeId is not null) QueryParams["storeId"] = storeId;



            CollectionFormatMap["sku"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/itemId/bySkus";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ItemId>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ItemId>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ItemId>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemId>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}