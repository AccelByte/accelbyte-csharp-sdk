// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// bulkGetAdminPlayerRecordByUserIdsV1
    ///
    /// Required Permission | `ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [READ]`
    /// --------------------|-------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Bulk get admin player record by userIds, max allowed 20 at a time.
    /// </summary>
    public class BulkGetAdminPlayerRecordByUserIdsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetAdminPlayerRecordByUserIdsV1Builder Builder { get => new BulkGetAdminPlayerRecordByUserIdsV1Builder(); }

        public class BulkGetAdminPlayerRecordByUserIdsV1Builder
            : OperationBuilder<BulkGetAdminPlayerRecordByUserIdsV1Builder>
        {





            internal BulkGetAdminPlayerRecordByUserIdsV1Builder() { }






            public BulkGetAdminPlayerRecordByUserIdsV1 Build(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                BulkGetAdminPlayerRecordByUserIdsV1 op = new BulkGetAdminPlayerRecordByUserIdsV1(this,
                    body,
                    key,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private BulkGetAdminPlayerRecordByUserIdsV1(BulkGetAdminPlayerRecordByUserIdsV1Builder builder,
            ModelsBulkUserIDsRequest body,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetAdminPlayerRecordByUserIdsV1(
            string key,
            string namespace_,
            Model.ModelsBulkUserIDsRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/adminrecords/{key}/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsBulkGetAdminPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminPlayerRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}