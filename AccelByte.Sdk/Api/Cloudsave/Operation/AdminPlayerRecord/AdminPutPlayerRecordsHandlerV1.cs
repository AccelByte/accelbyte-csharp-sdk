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
    /// adminPutPlayerRecordsHandlerV1
    ///
    /// This endpoints will create new player record or replace the existing player record in bulk.
    /// Maximum bulk key limit per request 10.
    /// </summary>
    public class AdminPutPlayerRecordsHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutPlayerRecordsHandlerV1Builder Builder { get => new AdminPutPlayerRecordsHandlerV1Builder(); }

        public class AdminPutPlayerRecordsHandlerV1Builder
            : OperationBuilder<AdminPutPlayerRecordsHandlerV1Builder>
        {





            internal AdminPutPlayerRecordsHandlerV1Builder() { }






            public AdminPutPlayerRecordsHandlerV1 Build(
                ModelsBulkUpdatePlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordsHandlerV1 op = new AdminPutPlayerRecordsHandlerV1(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminPutPlayerRecordsHandlerV1(AdminPutPlayerRecordsHandlerV1Builder builder,
            ModelsBulkUpdatePlayerRecordsRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPutPlayerRecordsHandlerV1(
            string namespace_,
            string userId,
            Model.ModelsBulkUpdatePlayerRecordsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelsBulkUpdatePlayerRecordResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelsBulkUpdatePlayerRecordResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelsBulkUpdatePlayerRecordResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsBulkUpdatePlayerRecordResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ModelsBulkUpdatePlayerRecordResponse<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsBulkUpdatePlayerRecordResponse<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsBulkUpdatePlayerRecordResponse<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}