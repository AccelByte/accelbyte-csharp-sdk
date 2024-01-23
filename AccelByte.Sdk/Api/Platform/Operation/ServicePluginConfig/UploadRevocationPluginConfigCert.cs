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
    /// uploadRevocationPluginConfigCert
    ///
    /// Upload revocation plugin custom config tls cert.Other detail info:
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:PLUGIN:REVOCATION, action=4 (UPDATE)
    ///   *  Returns : updated service plugin config
    /// </summary>
    public class UploadRevocationPluginConfigCert : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UploadRevocationPluginConfigCertBuilder Builder { get => new UploadRevocationPluginConfigCertBuilder(); }

        public class UploadRevocationPluginConfigCertBuilder
            : OperationBuilder<UploadRevocationPluginConfigCertBuilder>
        {



            public Stream? File { get; set; }



            internal UploadRevocationPluginConfigCertBuilder() { }




            public UploadRevocationPluginConfigCertBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public UploadRevocationPluginConfigCert Build(
                string namespace_
            )
            {
                UploadRevocationPluginConfigCert op = new UploadRevocationPluginConfigCert(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UploadRevocationPluginConfigCert(UploadRevocationPluginConfigCertBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.File is not null) FormParams["file"] = builder.File;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UploadRevocationPluginConfigCert(
            string namespace_,
            Stream? file
        )
        {
            PathParams["namespace"] = namespace_;


            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/revocation/plugins/revocation/revocation/customConfig/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RevocationPluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RevocationPluginConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RevocationPluginConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RevocationPluginConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}