// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminImportConfigV1
    ///
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:LOBBY:CONFIG [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Import config configuration from file. The existing configuration will be replaced.
    /// The json file to import can be obtained from the /export endpoint.
    /// 
    /// MaxDSWaitTime value is cannot less than 1, if null it will use default value in 120 (second)
    /// </summary>
    public class AdminImportConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminImportConfigV1Builder Builder { get => new AdminImportConfigV1Builder(); }

        public class AdminImportConfigV1Builder
            : OperationBuilder<AdminImportConfigV1Builder>
        {



            public Stream? File { get; set; }



            internal AdminImportConfigV1Builder() { }




            public AdminImportConfigV1Builder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public AdminImportConfigV1 Build(
                string namespace_
            )
            {
                AdminImportConfigV1 op = new AdminImportConfigV1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminImportConfigV1(AdminImportConfigV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File is not null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminImportConfigV1(
            string namespace_,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/config/namespaces/{namespace}/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsImportConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}