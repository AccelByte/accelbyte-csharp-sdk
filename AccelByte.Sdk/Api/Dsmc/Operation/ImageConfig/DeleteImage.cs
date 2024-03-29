// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// DeleteImage
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social.
    /// 
    /// This endpoint will delete an image that specified in the request parameter.
    /// 
    /// Default image is cannot be deleted and will throw error 422 (Unprocessable entity).
    /// </summary>
    public class DeleteImage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteImageBuilder Builder { get => new DeleteImageBuilder(); }

        public class DeleteImageBuilder
            : OperationBuilder<DeleteImageBuilder>
        {





            internal DeleteImageBuilder() { }






            public DeleteImage Build(
                string namespace_,
                string imageURI,
                string version
            )
            {
                DeleteImage op = new DeleteImage(this,
                    namespace_,
                    imageURI,
                    version
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteImage(DeleteImageBuilder builder,
            string namespace_,
            string imageURI,
            string version
        )
        {
            PathParams["namespace"] = namespace_;

            if (imageURI is not null) QueryParams["imageURI"] = imageURI;
            if (version is not null) QueryParams["version"] = version;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteImage(
            string namespace_,
            string imageURI,
            string version
        )
        {
            PathParams["namespace"] = namespace_;

            if (imageURI is not null) QueryParams["imageURI"] = imageURI;
            if (version is not null) QueryParams["version"] = version;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}