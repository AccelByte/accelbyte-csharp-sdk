// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// uploadKeys
    ///
    /// This API is used to upload keys with csv format to a key group.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=4 (UPDATE)
    ///   *  Returns : item data
    /// </summary>
    public class UploadKeys : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UploadKeysBuilder Builder { get => new UploadKeysBuilder(); }

        public class UploadKeysBuilder
            : OperationBuilder<UploadKeysBuilder>
        {



            public Stream? File { get; set; }



            internal UploadKeysBuilder() { }




            public UploadKeysBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public UploadKeys Build(
                string keyGroupId,
                string namespace_
            )
            {
                UploadKeys op = new UploadKeys(this,
                    keyGroupId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UploadKeys(UploadKeysBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;


            if (builder.File is not null) FormParams["file"] = builder.File;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UploadKeys(
            string keyGroupId,
            string namespace_,
            Stream? file
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;


            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.BulkOperationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}