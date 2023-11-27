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
    /// AdminGenerateOfficialContentUploadURLV2
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// </summary>
    public class AdminGenerateOfficialContentUploadURLV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateOfficialContentUploadURLV2Builder Builder { get => new AdminGenerateOfficialContentUploadURLV2Builder(); }

        public class AdminGenerateOfficialContentUploadURLV2Builder
            : OperationBuilder<AdminGenerateOfficialContentUploadURLV2Builder>
        {





            internal AdminGenerateOfficialContentUploadURLV2Builder() { }






            public AdminGenerateOfficialContentUploadURLV2 Build(
                ModelsGenerateContentUploadURLRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminGenerateOfficialContentUploadURLV2 op = new AdminGenerateOfficialContentUploadURLV2(this,
                    body,
                    channelId,
                    contentId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGenerateOfficialContentUploadURLV2(AdminGenerateOfficialContentUploadURLV2Builder builder,
            ModelsGenerateContentUploadURLRequest body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGenerateOfficialContentUploadURLV2(
            string channelId,
            string contentId,
            string namespace_,
            Model.ModelsGenerateContentUploadURLRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}/uploadUrl";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGenerateContentUploadURLResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGenerateContentUploadURLResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGenerateContentUploadURLResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGenerateContentUploadURLResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}