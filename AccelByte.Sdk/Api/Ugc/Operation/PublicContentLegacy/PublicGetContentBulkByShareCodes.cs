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
    /// PublicGetContentBulkByShareCodes
    ///
    /// Require valid user token.
    /// Maximum sharecodes per request 100
    /// </summary>
    public class PublicGetContentBulkByShareCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetContentBulkByShareCodesBuilder Builder { get => new PublicGetContentBulkByShareCodesBuilder(); }

        public class PublicGetContentBulkByShareCodesBuilder
            : OperationBuilder<PublicGetContentBulkByShareCodesBuilder>
        {





            internal PublicGetContentBulkByShareCodesBuilder() { }






            public PublicGetContentBulkByShareCodes Build(
                ModelsGetContentBulkByShareCodesRequest body,
                string namespace_
            )
            {
                PublicGetContentBulkByShareCodes op = new PublicGetContentBulkByShareCodes(this,
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

        private PublicGetContentBulkByShareCodes(PublicGetContentBulkByShareCodesBuilder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetContentBulkByShareCodes(
            string namespace_,
            Model.ModelsGetContentBulkByShareCodesRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json", "application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelsContentDownloadResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ModelsContentDownloadResponse<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}