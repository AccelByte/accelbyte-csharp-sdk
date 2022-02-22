// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// UpdateDeploymentOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint update a dedicated servers deployment override in a namespace.
    /// </summary>
    public class UpdateDeploymentOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateDeploymentOverrideBuilder Builder = new UpdateDeploymentOverrideBuilder();

        public class UpdateDeploymentOverrideBuilder
        {
            
            
            
            
            internal UpdateDeploymentOverrideBuilder() { }





            public UpdateDeploymentOverride Build(
                ModelsUpdateDeploymentOverrideRequest body,
                string deployment,
                string namespace_,
                string version
            )
            {
                return new UpdateDeploymentOverride(this,
                    body,                    
                    deployment,                    
                    namespace_,                    
                    version                    
                );
            }
        }

        private UpdateDeploymentOverride(UpdateDeploymentOverrideBuilder builder,
            ModelsUpdateDeploymentOverrideRequest body,
            string deployment,
            string namespace_,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateDeploymentOverride(
            string deployment,            
            string namespace_,            
            string version,            
            Model.ModelsUpdateDeploymentOverrideRequest body            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsDeploymentWithOverride? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}