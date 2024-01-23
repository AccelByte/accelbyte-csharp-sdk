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
    /// AdminUpdateOfficialContentFileLocation
    ///
    /// This endpoint should be used after calling generate official content upload url endpoint to commit the changes.
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// </summary>
    public class AdminUpdateOfficialContentFileLocation : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateOfficialContentFileLocationBuilder Builder { get => new AdminUpdateOfficialContentFileLocationBuilder(); }

        public class AdminUpdateOfficialContentFileLocationBuilder
            : OperationBuilder<AdminUpdateOfficialContentFileLocationBuilder>
        {





            internal AdminUpdateOfficialContentFileLocationBuilder() { }






            public AdminUpdateOfficialContentFileLocation Build(
                ModelsUpdateFileLocationRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentFileLocation op = new AdminUpdateOfficialContentFileLocation(this,
                    body,
                    channelId,
                    contentId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdateOfficialContentFileLocation(AdminUpdateOfficialContentFileLocationBuilder builder,
            ModelsUpdateFileLocationRequest body,
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

        public AdminUpdateOfficialContentFileLocation(
            string channelId,
            string contentId,
            string namespace_,
            Model.ModelsUpdateFileLocationRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}/fileLocation";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsUpdateContentResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}