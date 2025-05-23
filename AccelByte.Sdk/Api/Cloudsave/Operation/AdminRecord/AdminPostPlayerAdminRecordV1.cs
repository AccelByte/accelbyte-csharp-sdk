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
    /// adminPostPlayerAdminRecordV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new admin player record or append the existing admin game record.
    /// 
    /// **Append example:**
    /// 
    /// Example 1
    /// - Existing JSON:
    /// 
    /// `{ "data1": "value" }`
    /// 
    /// - New JSON:
    /// 
    /// `{ "data2": "new value" }`
    /// 
    /// - Result:
    /// 
    /// `{ "data1": "value", "data2": "new value" }`
    /// 
    /// 
    /// Example 2
    /// - Existing JSON:
    /// 
    /// `{ "data1": { "data2": "value" }`
    /// 
    /// - New JSON:
    /// 
    /// `{ "data1": { "data3": "new value" }`
    /// 
    /// - Result:
    /// 
    /// `{ "data1": { "data2": "value", "data3": "new value" }`
    /// 
    /// 
    /// ## Record Metadata
    /// 
    /// Metadata allows user to define the behaviour of the record.
    /// Metadata can be defined in request body with field name **__META**.
    /// When creating record, if **__META** field is not defined, the metadata value will use the default value.
    /// When updating record, if **__META** field is not defined, the existing metadata value will stay as is.
    /// 
    /// **Metadata List:**
    /// 1. tags (default: *empty array*, type: array of string)
    /// Indicate the tagging for the admin record.
    /// 2. ttl_config (default: *empty*, type: object)
    /// Indicate the TTL configuration for the admin record.
    /// action:
    /// - DELETE: record will be deleted after TTL is reached
    /// 
    /// **Request Body Example:**
    /// ```
    /// {
    /// "__META": {
    /// "tags": ["tag1", "tag2"],
    /// "ttl_config": {
    /// "expires_at": "2026-01-02T15:04:05Z", // should be in RFC3339 format
    /// "action": "DELETE"
    /// },
    /// }
    /// ...
    /// }
    /// ```
    /// 
    /// ## Recommended Request Body Size
    /// 
    /// To ensure optimal performance and efficient resource utilization, it is recommended that the request body size for this endpoint does not exceed 250 KB.
    /// 
    /// ## Exceeding the recommended limit
    /// 
    /// While it's possible to handle larger request, exceeding this limit may lead to increased processing time, potential performance degradation, and potential timeout issues.
    /// </summary>
    public class AdminPostPlayerAdminRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPostPlayerAdminRecordV1Builder Builder { get => new AdminPostPlayerAdminRecordV1Builder(); }

        public class AdminPostPlayerAdminRecordV1Builder
            : OperationBuilder<AdminPostPlayerAdminRecordV1Builder>
        {





            internal AdminPostPlayerAdminRecordV1Builder() { }






            public AdminPostPlayerAdminRecordV1 Build(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerAdminRecordV1 op = new AdminPostPlayerAdminRecordV1(this,
                    body,
                    key,
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

        private AdminPostPlayerAdminRecordV1(AdminPostPlayerAdminRecordV1Builder builder,
            ModelsAdminPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPostPlayerAdminRecordV1(
            string key,
            string namespace_,
            string userId,
            Model.ModelsAdminPlayerRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsAdminPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsAdminPlayerRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsAdminPlayerRecordResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminPlayerRecordResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminPlayerRecordResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}