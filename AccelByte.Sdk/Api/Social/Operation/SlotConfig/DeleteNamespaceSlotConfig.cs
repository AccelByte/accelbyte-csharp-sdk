// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// deleteNamespaceSlotConfig
    ///
    /// Deletes a namespace slot configuration, the configuration will be default after delete.
    /// Other detail info:
    /// 
    ///   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:SLOTCONFIG", action=8 (DELETE)
    /// </summary>
    public class DeleteNamespaceSlotConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteNamespaceSlotConfigBuilder Builder = new DeleteNamespaceSlotConfigBuilder();

        public class DeleteNamespaceSlotConfigBuilder
        {
            
            internal DeleteNamespaceSlotConfigBuilder() { }





            public DeleteNamespaceSlotConfig Build(
                string namespace_
            )
            {
                return new DeleteNamespaceSlotConfig(this,
                    namespace_                    
                );
            }
        }

        private DeleteNamespaceSlotConfig(DeleteNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public DeleteNamespaceSlotConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/social/admin/namespaces/{namespace}/config";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

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