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
    /// adminPutAdminGameRecordConcurrentHandlerV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new game record or replace the existing game record.
    /// 
    /// **Replace behaviour:**
    /// The existing value will be replaced completely with the new value.
    /// 
    /// Example
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
    /// `{ "data2": "new value" }`
    /// 
    /// 
    /// 
    /// ## Restriction
    /// This is the restriction of Key Naming for the record:
    /// 1. Cannot use **"."** as the key name
    /// - `{ "data.2": "value" }`
    /// 2. Cannot use **"$"** as the prefix in key names
    /// - `{ "$data": "value" }`
    /// 3. Cannot use empty string in key names
    /// - `{ "": "value" }`
    /// 
    /// 
    /// ## Reserved Word
    /// 
    /// Reserved Word List: **__META**
    /// 
    /// The reserved word cannot be used as a field in record value,
    /// If still defining the field when creating or updating the record, it will be ignored.
    /// 
    /// 
    /// ## Parameters Notes
    /// 1. updatedAt (required: true)
    /// Time format style: RFC3339
    /// 2. value
    /// Json
    /// 3. tags (default: *empty array*, type: array of string)
    /// Indicate the tagging for the admin record.
    /// **Request Body Example:**
    /// ```
    /// {
    /// "value": {},
    /// "updatedAt": "2022-03-17T10:42:15.444Z",
    /// "tags": ["tag1", "tag2"]
    /// }
    /// ```
    /// ## Optimistic Concurrency Control
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class AdminPutAdminGameRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutAdminGameRecordConcurrentHandlerV1Builder Builder { get => new AdminPutAdminGameRecordConcurrentHandlerV1Builder(); }

        public class AdminPutAdminGameRecordConcurrentHandlerV1Builder
            : OperationBuilder<AdminPutAdminGameRecordConcurrentHandlerV1Builder>
        {





            internal AdminPutAdminGameRecordConcurrentHandlerV1Builder() { }






            public AdminPutAdminGameRecordConcurrentHandlerV1 Build(
                ModelsAdminGameConcurrentRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordConcurrentHandlerV1 op = new AdminPutAdminGameRecordConcurrentHandlerV1(this,
                    body,
                    key,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminPutAdminGameRecordConcurrentHandlerV1(AdminPutAdminGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminGameConcurrentRecordRequest body,
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

        public AdminPutAdminGameRecordConcurrentHandlerV1(
            string key,
            string namespace_,
            Model.ModelsAdminGameConcurrentRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/concurrent/adminrecords/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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