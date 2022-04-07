// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminExportConfigV1
    ///
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:LOBBY:CONFIG [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Export lobby configuration to a json file. The file can then be imported from the /import endpoint.
    /// </summary>
    public class AdminExportConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminExportConfigV1Builder Builder = new AdminExportConfigV1Builder();

        public class AdminExportConfigV1Builder
        {
            
            internal AdminExportConfigV1Builder() { }





            public AdminExportConfigV1 Build(
                string namespace_
            )
            {
                return new AdminExportConfigV1(this,
                    namespace_                    
                );
            }
        }

        private AdminExportConfigV1(AdminExportConfigV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public AdminExportConfigV1(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/config/namespaces/{namespace}/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsConfigExport? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigExport>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigExport>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}