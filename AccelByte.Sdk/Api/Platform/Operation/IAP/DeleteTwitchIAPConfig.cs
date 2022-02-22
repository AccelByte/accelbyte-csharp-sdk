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
    /// deleteTwitchIAPConfig
    ///
    /// Delete twitch iap config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=8 (DELETE)
    /// </summary>
    public class DeleteTwitchIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTwitchIAPConfigBuilder Builder = new DeleteTwitchIAPConfigBuilder();

        public class DeleteTwitchIAPConfigBuilder
        {
            
            internal DeleteTwitchIAPConfigBuilder() { }





            public DeleteTwitchIAPConfig Build(
                string namespace_
            )
            {
                return new DeleteTwitchIAPConfig(this,
                    namespace_                    
                );
            }
        }

        private DeleteTwitchIAPConfig(DeleteTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public DeleteTwitchIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/twitch";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}