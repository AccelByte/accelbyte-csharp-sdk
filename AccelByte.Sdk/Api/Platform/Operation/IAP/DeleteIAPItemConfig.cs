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
    /// deleteIAPItemConfig
    ///
    /// delete a iap item config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:IAP:CONFIG" , action=8 (DELETE)
    /// </summary>
    public class DeleteIAPItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteIAPItemConfigBuilder Builder = new DeleteIAPItemConfigBuilder();

        public class DeleteIAPItemConfigBuilder
        {
            
            internal DeleteIAPItemConfigBuilder() { }





            public DeleteIAPItemConfig Build(
                string namespace_
            )
            {
                return new DeleteIAPItemConfig(this,
                    namespace_                    
                );
            }
        }

        private DeleteIAPItemConfig(DeleteIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public DeleteIAPItemConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/item";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

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