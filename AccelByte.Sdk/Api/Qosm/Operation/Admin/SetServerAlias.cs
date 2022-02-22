// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// SetServerAlias
    ///
    /// ```
    /// Required permission: ADMIN:QOS:SERVER [UDPATE]
    /// Required scope: social
    /// 
    /// This endpoint modifies a registered QoS service's region alias.
    /// ```
    /// </summary>
    public class SetServerAlias : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetServerAliasBuilder Builder = new SetServerAliasBuilder();

        public class SetServerAliasBuilder
        {
            
            
            internal SetServerAliasBuilder() { }





            public SetServerAlias Build(
                ModelsSetAliasRequest body,
                string region
            )
            {
                return new SetServerAlias(this,
                    body,                    
                    region                    
                );
            }
        }

        private SetServerAlias(SetServerAliasBuilder builder,
            ModelsSetAliasRequest body,
            string region
        )
        {
            PathParams["region"] = region;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public SetServerAlias(
            string region,            
            Model.ModelsSetAliasRequest body            
        )
        {
            PathParams["region"] = region;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/qosm/admin/servers/{region}/alias";

        public override HttpMethod Method => HttpMethod.Post;

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