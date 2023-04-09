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
    /// updateItemPurchaseCondition
    ///
    /// This API is used to update item purchase condition
    /// </summary>
    public class UpdateItemPurchaseCondition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateItemPurchaseConditionBuilder Builder { get => new UpdateItemPurchaseConditionBuilder(); }

        public class UpdateItemPurchaseConditionBuilder
            : OperationBuilder<UpdateItemPurchaseConditionBuilder>
        {


            public Model.PurchaseConditionUpdate? Body { get; set; }




            internal UpdateItemPurchaseConditionBuilder() { }



            public UpdateItemPurchaseConditionBuilder SetBody(Model.PurchaseConditionUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateItemPurchaseCondition Build(
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = new UpdateItemPurchaseCondition(this,
                    itemId,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateItemPurchaseCondition(UpdateItemPurchaseConditionBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateItemPurchaseCondition(
            string itemId,
            string namespace_,
            string storeId,
            Model.PurchaseConditionUpdate body
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/purchase/condition";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.FullItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.FullItemInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}