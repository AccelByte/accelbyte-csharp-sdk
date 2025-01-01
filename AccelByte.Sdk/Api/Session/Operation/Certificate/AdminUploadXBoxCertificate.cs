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
    /// adminUploadXBoxCertificate
    ///
    /// Upload certificates for XBox. Certificate must be in the valid form of PFX format. 'certname'' must be specified to 'xbl-pfx' for Session Sync to work
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AdminUploadXBoxCertificate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUploadXBoxCertificateBuilder Builder { get => new AdminUploadXBoxCertificateBuilder(); }

        public class AdminUploadXBoxCertificateBuilder
            : OperationBuilder<AdminUploadXBoxCertificateBuilder>
        {



            public string? Description { get; set; }



            internal AdminUploadXBoxCertificateBuilder() { }




            public AdminUploadXBoxCertificateBuilder SetDescription(string _description)
            {
                Description = _description;
                return this;
            }



            public AdminUploadXBoxCertificate Build(
                string certname,
                Stream file,
                string password,
                string namespace_
            )
            {
                AdminUploadXBoxCertificate op = new AdminUploadXBoxCertificate(this,
                    certname,
                    file,
                    password,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUploadXBoxCertificate(AdminUploadXBoxCertificateBuilder builder,
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

        public AdminUploadXBoxCertificate(
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