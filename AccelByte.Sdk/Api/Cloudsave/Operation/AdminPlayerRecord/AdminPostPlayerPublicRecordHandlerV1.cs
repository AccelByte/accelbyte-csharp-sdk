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
    /// adminPostPlayerPublicRecordHandlerV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new player public record or append the existing player public record.
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
    /// ## Warning: This endpoint is going to deprecate
    /// 
    /// This endpoint is going to deprecate in the future please don't use it.
    /// 
    /// For alternative, please use these endpoints:
    /// - **POST /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}** and utilizing **__META** functionality
    /// - **PUT /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}** and utilizing **__META** functionality
    /// - **DELETE /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}**
    /// </summary>
    public class AdminPostPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPostPlayerPublicRecordHandlerV1Builder Builder { get => new AdminPostPlayerPublicRecordHandlerV1Builder(); }

        public class AdminPostPlayerPublicRecordHandlerV1Builder
            : OperationBuilder<AdminPostPlayerPublicRecordHandlerV1Builder>
        {





            internal AdminPostPlayerPublicRecordHandlerV1Builder() { }






            public AdminPostPlayerPublicRecordHandlerV1 Build(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerPublicRecordHandlerV1 op = new AdminPostPlayerPublicRecordHandlerV1(this,
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

        private AdminPostPlayerPublicRecordHandlerV1(AdminPostPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
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

        public AdminPostPlayerPublicRecordHandlerV1(
            string key,
            string namespace_,
            string userId,
            Model.ModelsPlayerRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsPlayerRecordResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}