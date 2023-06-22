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
    /// AdminGetUserContentByShareCode
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:*:CONTENT [READ].
    /// </summary>
    public class AdminGetUserContentByShareCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserContentByShareCodeBuilder Builder { get => new AdminGetUserContentByShareCodeBuilder(); }

        public class AdminGetUserContentByShareCodeBuilder
            : OperationBuilder<AdminGetUserContentByShareCodeBuilder>
        {





            internal AdminGetUserContentByShareCodeBuilder() { }






            public AdminGetUserContentByShareCode Build(
                string namespace_,
                string shareCode
            )
            {
                AdminGetUserContentByShareCode op = new AdminGetUserContentByShareCode(this,
                    namespace_,
                    shareCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetUserContentByShareCode(AdminGetUserContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserContentByShareCode(
            string namespace_,
            string shareCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsContentDownloadResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}