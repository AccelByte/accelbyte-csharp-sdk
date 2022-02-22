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
    /// updateStadiaJsonConfigFile
    ///
    /// Upload stadia json config file.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated stadia iap config
    /// </summary>
    public class UpdateStadiaJsonConfigFile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateStadiaJsonConfigFileBuilder Builder = new UpdateStadiaJsonConfigFileBuilder();

        public class UpdateStadiaJsonConfigFileBuilder
        {
            
            public Stream? File { get; set; }
            
            internal UpdateStadiaJsonConfigFileBuilder() { }




            public UpdateStadiaJsonConfigFileBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }


            public UpdateStadiaJsonConfigFile Build(
                string namespace_
            )
            {
                return new UpdateStadiaJsonConfigFile(this,
                    namespace_                    
                );
            }
        }

        private UpdateStadiaJsonConfigFile(UpdateStadiaJsonConfigFileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File != null) FormParams["file"] = builder.File;
            
            
            
        }
        #endregion

        public UpdateStadiaJsonConfigFile(
            string namespace_,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file != null) FormParams["file"] = file;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/stadia/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StadiaIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StadiaIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StadiaIAPConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}