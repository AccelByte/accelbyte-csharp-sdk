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
    /// cloneStore
    ///
    /// This API is used to clone a store. Usually clone a draft store to published store because published store can't directly edit content.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=1 (CREATE)
    ///   *  Returns : clone store info
    /// </summary>
    public class CloneStore : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CloneStoreBuilder Builder = new CloneStoreBuilder();

        public class CloneStoreBuilder
            : OperationBuilder<CloneStoreBuilder>
        {

            public string? TargetStoreId { get; set; }





            internal CloneStoreBuilder() { }


            public CloneStoreBuilder SetTargetStoreId(string _targetStoreId)
            {
                TargetStoreId = _targetStoreId;
                return this;
            }





            public CloneStore Build(
                string namespace_,
                string storeId
            )
            {
                CloneStore op = new CloneStore(this,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CloneStore(CloneStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (builder.TargetStoreId is not null) QueryParams["targetStoreId"] = builder.TargetStoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CloneStore(
            string namespace_,
            string storeId,
            string? targetStoreId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (targetStoreId is not null) QueryParams["targetStoreId"] = targetStoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/clone";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.StoreInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}