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
    /// DeleteDeploymentOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint delete a dedicated server deployment override in a namespace
    /// </summary>
    public class DeleteDeploymentOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteDeploymentOverrideBuilder Builder = new DeleteDeploymentOverrideBuilder();

        public class DeleteDeploymentOverrideBuilder
        {
            
            
            
            internal DeleteDeploymentOverrideBuilder() { }





            public DeleteDeploymentOverride Build(
                string deployment,
                string namespace_,
                string version
            )
            {
                return new DeleteDeploymentOverride(this,
                    deployment,                    
                    namespace_,                    
                    version                    
                );
            }
        }

        private DeleteDeploymentOverride(DeleteDeploymentOverrideBuilder builder,
            string deployment,
            string namespace_,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            
            
            
            
            
        }
        #endregion

        public DeleteDeploymentOverride(
            string deployment,            
            string namespace_,            
            string version            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            
            
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}";

        public override HttpMethod Method => HttpMethod.Delete;

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