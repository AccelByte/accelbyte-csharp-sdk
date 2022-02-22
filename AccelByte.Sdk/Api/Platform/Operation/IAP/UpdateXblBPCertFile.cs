// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateXblBPCertFile
    ///
    /// Upload xbl business partner cert file.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated xbl iap config
    /// </summary>
    public class UpdateXblBPCertFile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXblBPCertFileBuilder Builder = new UpdateXblBPCertFileBuilder();

        public class UpdateXblBPCertFileBuilder
        {
            
            public Stream? File { get; set; }
            
            public string? Password { get; set; }
            
            internal UpdateXblBPCertFileBuilder() { }




            public UpdateXblBPCertFileBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }

            public UpdateXblBPCertFileBuilder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }


            public UpdateXblBPCertFile Build(
                string namespace_
            )
            {
                return new UpdateXblBPCertFile(this,
                    namespace_                    
                );
            }
        }

        private UpdateXblBPCertFile(UpdateXblBPCertFileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File != null) FormParams["file"] = builder.File;
            if (builder.Password != null) FormParams["password"] = builder.Password;
            
            
            
        }
        #endregion

        public UpdateXblBPCertFile(
            string namespace_,            
            Stream? file,            
            string? password            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file != null) FormParams["file"] = file;
            if (password != null) FormParams["password"] = password;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/xbl/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.XblIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}