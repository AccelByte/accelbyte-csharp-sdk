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
    /// getPlatformDLCConfig
    ///
    /// Get Platform DLC config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:DLC:CONFIG" , action=2 (READ)
    /// </summary>
    public class GetPlatformDLCConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPlatformDLCConfigBuilder Builder = new GetPlatformDLCConfigBuilder();

        public class GetPlatformDLCConfigBuilder
        {
            
            internal GetPlatformDLCConfigBuilder() { }





            public GetPlatformDLCConfig Build(
                string namespace_
            )
            {
                return new GetPlatformDLCConfig(this,
                    namespace_                    
                );
            }
        }

        private GetPlatformDLCConfig(GetPlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public GetPlatformDLCConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/dlc/config/platformMap";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PlatformDLCConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PlatformDLCConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PlatformDLCConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}