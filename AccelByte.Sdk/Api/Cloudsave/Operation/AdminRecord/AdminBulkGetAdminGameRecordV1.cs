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
    /// adminBulkGetAdminGameRecordV1
    ///
    /// Bulk get admin game records. Maximum key per request 20.
    /// </summary>
    public class AdminBulkGetAdminGameRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkGetAdminGameRecordV1Builder Builder { get => new AdminBulkGetAdminGameRecordV1Builder(); }

        public class AdminBulkGetAdminGameRecordV1Builder
            : OperationBuilder<AdminBulkGetAdminGameRecordV1Builder>
        {





            internal AdminBulkGetAdminGameRecordV1Builder() { }






            public AdminBulkGetAdminGameRecordV1 Build(
                ModelsBulkGetAdminGameRecordRequest body,
                string namespace_
            )
            {
                AdminBulkGetAdminGameRecordV1 op = new AdminBulkGetAdminGameRecordV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminBulkGetAdminGameRecordV1(AdminBulkGetAdminGameRecordV1Builder builder,
            ModelsBulkGetAdminGameRecordRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBulkGetAdminGameRecordV1(
            string namespace_,
            Model.ModelsBulkGetAdminGameRecordRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsBulkGetAdminGameRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminGameRecordResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminGameRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminGameRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}