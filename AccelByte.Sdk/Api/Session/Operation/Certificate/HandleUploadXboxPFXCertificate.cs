// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// HandleUploadXboxPFXCertificate
    ///
    /// Upload certificates for xbox. Certificate must be in the valid form of PFX format.
    /// </summary>
    public class HandleUploadXboxPFXCertificate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static HandleUploadXboxPFXCertificateBuilder Builder { get => new HandleUploadXboxPFXCertificateBuilder(); }

        public class HandleUploadXboxPFXCertificateBuilder
            : OperationBuilder<HandleUploadXboxPFXCertificateBuilder>
        {



            public string? Description { get; set; }



            internal HandleUploadXboxPFXCertificateBuilder() { }




            public HandleUploadXboxPFXCertificateBuilder SetDescription(string _description)
            {
                Description = _description;
                return this;
            }



            public HandleUploadXboxPFXCertificate Build(
                string certname,
                Stream file,
                string password,
                string namespace_
            )
            {
                HandleUploadXboxPFXCertificate op = new HandleUploadXboxPFXCertificate(this,
                    certname,
                    file,
                    password,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private HandleUploadXboxPFXCertificate(HandleUploadXboxPFXCertificateBuilder builder,
            string certname,
            Stream file,
            string password,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.Description is not null) FormParams["description"] = builder.Description;
            if (certname is not null) FormParams["certname"] = certname;
            if (file is not null) FormParams["file"] = file;
            if (password is not null) FormParams["password"] = password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public HandleUploadXboxPFXCertificate(
            string namespace_,
            string? description,
            string certname,
            Stream file,
            string password
        )
        {
            PathParams["namespace"] = namespace_;


            if (description is not null) FormParams["description"] = description;
            if (certname is not null) FormParams["certname"] = certname;
            if (file is not null) FormParams["file"] = file;
            if (password is not null) FormParams["password"] = password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/certificates/pfx/platforms/xbl";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPlatformCredentials? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}