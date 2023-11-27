// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminGetContentBulkByShareCodesV2
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:*:CONTENT [READ].
    /// Maximum sharecodes per request 100
    /// </summary>
    public class AdminGetContentBulkByShareCodesV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetContentBulkByShareCodesV2Builder Builder { get => new AdminGetContentBulkByShareCodesV2Builder(); }

        public class AdminGetContentBulkByShareCodesV2Builder
            : OperationBuilder<AdminGetContentBulkByShareCodesV2Builder>
        {





            internal AdminGetContentBulkByShareCodesV2Builder() { }






            public AdminGetContentBulkByShareCodesV2 Build(
                ModelsGetContentBulkByShareCodesRequest body,
                string namespace_
            )
            {
                AdminGetContentBulkByShareCodesV2 op = new AdminGetContentBulkByShareCodesV2(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetContentBulkByShareCodesV2(AdminGetContentBulkByShareCodesV2Builder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetContentBulkByShareCodesV2(
            string namespace_,
            Model.ModelsGetContentBulkByShareCodesRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/contents/sharecodes/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelsContentDownloadResponseV2>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ModelsContentDownloadResponseV2<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}