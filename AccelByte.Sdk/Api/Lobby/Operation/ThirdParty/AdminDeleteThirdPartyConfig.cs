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
    /// adminDeleteThirdPartyConfig
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:THIRDPARTY:CONFIG [DELETE]` with scope `social`
    /// 
    /// delete third party config in a namespace.
    /// </summary>
    public class AdminDeleteThirdPartyConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteThirdPartyConfigBuilder Builder = new AdminDeleteThirdPartyConfigBuilder();

        public class AdminDeleteThirdPartyConfigBuilder
        {
            
            internal AdminDeleteThirdPartyConfigBuilder() { }





            public AdminDeleteThirdPartyConfig Build(
                string namespace_
            )
            {
                return new AdminDeleteThirdPartyConfig(this,
                    namespace_                    
                );
            }
        }

        private AdminDeleteThirdPartyConfig(AdminDeleteThirdPartyConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public AdminDeleteThirdPartyConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public string? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<string>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<string>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}