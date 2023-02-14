// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkFetchOrDefaultStatItems
    ///
    /// Bulk fetch multiple user's stat item values for a given namespace and statCode.
    /// NOTE: If stat item does not exist, will return default value. Other detail info:
    /// + *Required permission*: resource=ADMIN:NAMESPACE:{namespace}:STATITEM, action=2 (READ)
    /// + *Returns*: list of user's stat item values
    /// </summary>
    public class BulkFetchOrDefaultStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkFetchOrDefaultStatItemsBuilder Builder { get => new BulkFetchOrDefaultStatItemsBuilder(); }

        public class BulkFetchOrDefaultStatItemsBuilder
            : OperationBuilder<BulkFetchOrDefaultStatItemsBuilder>
        {





            internal BulkFetchOrDefaultStatItemsBuilder() { }






            public BulkFetchOrDefaultStatItems Build(
                string namespace_,
                string statCode,
                List<string> userIds
            )
            {
                BulkFetchOrDefaultStatItems op = new BulkFetchOrDefaultStatItems(this,
                    namespace_,
                    statCode,
                    userIds
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkFetchOrDefaultStatItems(BulkFetchOrDefaultStatItemsBuilder builder,
            string namespace_,
            string statCode,
            List<string> userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;



            CollectionFormatMap["userIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkFetchOrDefaultStatItems(
            string namespace_,
            string statCode,
            List<string> userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;



            CollectionFormatMap["userIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statitems/value/bulk/getOrDefault";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ADTOObjectForUserStatItemValue>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}