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
    /// bulkGetPlayerRecordSizeHandlerV1
    ///
    /// Required Permission | `ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [READ]`
    /// --------------------|-------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// Bulk get player's record size, max allowed 20 at a time, that can be
    /// retrieved using this endpoint.
    /// </summary>
    public class BulkGetPlayerRecordSizeHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetPlayerRecordSizeHandlerV1Builder Builder { get => new BulkGetPlayerRecordSizeHandlerV1Builder(); }

        public class BulkGetPlayerRecordSizeHandlerV1Builder
            : OperationBuilder<BulkGetPlayerRecordSizeHandlerV1Builder>
        {





            internal BulkGetPlayerRecordSizeHandlerV1Builder() { }






            public BulkGetPlayerRecordSizeHandlerV1 Build(
                ModelsBulkUserKeyRequest body,
                string namespace_
            )
            {
                BulkGetPlayerRecordSizeHandlerV1 op = new BulkGetPlayerRecordSizeHandlerV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private BulkGetPlayerRecordSizeHandlerV1(BulkGetPlayerRecordSizeHandlerV1Builder builder,
            ModelsBulkUserKeyRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetPlayerRecordSizeHandlerV1(
            string namespace_,
            Model.ModelsBulkUserKeyRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/bulk/records/size";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsBulkGetPlayerRecordSizeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordSizeResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordSizeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordSizeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}