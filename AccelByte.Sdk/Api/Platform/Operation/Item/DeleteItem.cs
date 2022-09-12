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
    /// deleteItem
    ///
    /// This API is used to delete an item permanently.
    /// 
    /// force: the default value should be: false. When the value is:
    /// * false: only the items in the draft store that have never been published yet can be removed.
    /// *  true: the item in the draft store(even been published before) can be removed.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=8 (DELETE)
    /// </summary>
    public class DeleteItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteItemBuilder Builder = new DeleteItemBuilder();

        public class DeleteItemBuilder
            : OperationBuilder<DeleteItemBuilder>
        {

            public bool? Force { get; set; }

            public string? StoreId { get; set; }





            internal DeleteItemBuilder() { }


            public DeleteItemBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }

            public DeleteItemBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public DeleteItem Build(
                string itemId,
                string namespace_
            )
            {
                DeleteItem op = new DeleteItem(this,
                    itemId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteItem(DeleteItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteItem(
            string itemId,
            string namespace_,
            bool? force,
            string? storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (force != null) QueryParams["force"] = Convert.ToString(force)!;
            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}