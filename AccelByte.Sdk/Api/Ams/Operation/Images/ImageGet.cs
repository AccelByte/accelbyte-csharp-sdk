// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// ImageGet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:ACCOUNT [READ]
    /// </summary>
    public class ImageGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImageGetBuilder Builder { get => new ImageGetBuilder(); }

        public class ImageGetBuilder
            : OperationBuilder<ImageGetBuilder>
        {





            internal ImageGetBuilder() { }






            public ImageGet Build(
                string imageID,
                string namespace_
            )
            {
                ImageGet op = new ImageGet(this,
                    imageID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private ImageGet(ImageGetBuilder builder,
            string imageID,
            string namespace_
        )
        {
            PathParams["imageID"] = imageID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ImageGet(
            string imageID,
            string namespace_
        )
        {
            PathParams["imageID"] = imageID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/images/{imageID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiImageDetails? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiImageDetails>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiImageDetails>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiImageDetails>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}