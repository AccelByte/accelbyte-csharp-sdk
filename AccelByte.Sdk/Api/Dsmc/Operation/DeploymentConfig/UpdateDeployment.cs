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
    /// UpdateDeployment
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint update a dedicated servers deployment in a namespace.
    /// </summary>
    public class UpdateDeployment : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateDeploymentBuilder Builder = new UpdateDeploymentBuilder();

        public class UpdateDeploymentBuilder
            : OperationBuilder<UpdateDeploymentBuilder>
        {
            
            
            
            internal UpdateDeploymentBuilder() { }





            public UpdateDeployment Build(
                ModelsUpdateDeploymentRequest body,
                string deployment,
                string namespace_
            )
            {
                UpdateDeployment op = new UpdateDeployment(this,
                    body,                    
                    deployment,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateDeployment(UpdateDeploymentBuilder builder,
            ModelsUpdateDeploymentRequest body,
            string deployment,
            string namespace_
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateDeployment(
            string deployment,            
            string namespace_,            
            Model.ModelsUpdateDeploymentRequest body            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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