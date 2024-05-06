// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGeneratedUploadUrl
    ///
    /// Generate an upload URL. It's valid for 10 minutes.
    /// Other detail info:
    /// 
    ///   * Action code : 11101
    ///   *  Returns : URL data
    /// </summary>
    public class PublicGeneratedUploadUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGeneratedUploadUrlBuilder Builder { get => new PublicGeneratedUploadUrlBuilder(); }

        public class PublicGeneratedUploadUrlBuilder
            : OperationBuilder<PublicGeneratedUploadUrlBuilder>
        {





            internal PublicGeneratedUploadUrlBuilder() { }






            public PublicGeneratedUploadUrl Build(
                string folder,
                string namespace_,
                string fileType
            )
            {
                PublicGeneratedUploadUrl op = new PublicGeneratedUploadUrl(this,
                    folder,
                    namespace_,
                    fileType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGeneratedUploadUrl(PublicGeneratedUploadUrlBuilder builder,
            string folder,
            string namespace_,
            string fileType
        )
        {
            PathParams["folder"] = folder;
            PathParams["namespace"] = namespace_;

            if (fileType is not null) QueryParams["fileType"] = fileType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGeneratedUploadUrl(
            string folder,
            string namespace_,
            string fileType
        )
        {
            PathParams["folder"] = folder;
            PathParams["namespace"] = namespace_;

            if (fileType is not null) QueryParams["fileType"] = fileType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/folders/{folder}/files";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.FileUploadUrlInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}