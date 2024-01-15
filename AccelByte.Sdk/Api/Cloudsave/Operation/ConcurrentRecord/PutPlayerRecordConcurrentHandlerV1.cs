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
    /// putPlayerRecordConcurrentHandlerV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new player record or replace the existing player record.
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
    /// ## Optimistic Concurrency Control
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class PutPlayerRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PutPlayerRecordConcurrentHandlerV1Builder Builder { get => new PutPlayerRecordConcurrentHandlerV1Builder(); }

        public class PutPlayerRecordConcurrentHandlerV1Builder
            : OperationBuilder<PutPlayerRecordConcurrentHandlerV1Builder>
        {

            public bool? ResponseBody { get; set; }





            internal PutPlayerRecordConcurrentHandlerV1Builder() { }


            public PutPlayerRecordConcurrentHandlerV1Builder SetResponseBody(bool _responseBody)
            {
                ResponseBody = _responseBody;
                return this;
            }





            public PutPlayerRecordConcurrentHandlerV1 Build(
                ModelsConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerRecordConcurrentHandlerV1 op = new PutPlayerRecordConcurrentHandlerV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PutPlayerRecordConcurrentHandlerV1(PutPlayerRecordConcurrentHandlerV1Builder builder,
            ModelsConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.ResponseBody != null) QueryParams["responseBody"] = Convert.ToString(builder.ResponseBody)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PutPlayerRecordConcurrentHandlerV1(
            string key,
            string namespace_,
            string userId,
            bool? responseBody,
            Model.ModelsConcurrentRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (responseBody != null) QueryParams["responseBody"] = Convert.ToString(responseBody)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/concurrent/records/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPlayerRecordConcurrentUpdateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPlayerRecordConcurrentUpdateResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPlayerRecordConcurrentUpdateResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordConcurrentUpdateResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}