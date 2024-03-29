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
    /// UpdateContentLikeStatusV2
    ///
    /// This endpoint will update like/unlike state from a content
    /// </summary>
    public class UpdateContentLikeStatusV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateContentLikeStatusV2Builder Builder { get => new UpdateContentLikeStatusV2Builder(); }

        public class UpdateContentLikeStatusV2Builder
            : OperationBuilder<UpdateContentLikeStatusV2Builder>
        {





            internal UpdateContentLikeStatusV2Builder() { }






            public UpdateContentLikeStatusV2 Build(
                ModelsContentLikeRequest body,
                string contentId,
                string namespace_
            )
            {
                UpdateContentLikeStatusV2 op = new UpdateContentLikeStatusV2(this,
                    body,
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

        private UpdateContentLikeStatusV2(UpdateContentLikeStatusV2Builder builder,
            ModelsContentLikeRequest body,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateContentLikeStatusV2(
            string contentId,
            string namespace_,
            Model.ModelsContentLikeRequest body
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/contents/{contentId}/like";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json", "application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsContentLikeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsContentLikeResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsContentLikeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentLikeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}