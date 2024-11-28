// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// CreateDeploymentV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:DEPLOYMENT [CREATE]`
    /// 
    /// Creates Deployment for extend service
    /// 
    /// This Endpoint will create new deployment and apply all of the secrets and variable as environment variable
    /// 
    /// Required:
    /// - Valid Access Token
    /// - Valid Image Version Created on Uploading image with docker or other method
    /// - Valid App name
    /// - Valid Namespace name
    /// </summary>
    public class CreateDeploymentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateDeploymentV2Builder Builder { get => new CreateDeploymentV2Builder(); }

        public class CreateDeploymentV2Builder
            : OperationBuilder<CreateDeploymentV2Builder>
        {





            internal CreateDeploymentV2Builder() { }






            public CreateDeploymentV2 Build(
                ApimodelCreateDeploymentV2Request body,
                string app,
                string namespace_
            )
            {
                CreateDeploymentV2 op = new CreateDeploymentV2(this,
                    body,                    
                    app,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateDeploymentV2(CreateDeploymentV2Builder builder,
            ApimodelCreateDeploymentV2Request body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateDeploymentV2(
            string app,            
            string namespace_,            
            Model.ApimodelCreateDeploymentV2Request body            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/deployments";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApimodelCreateDeploymentV2Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelCreateDeploymentV2Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelCreateDeploymentV2Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelCreateDeploymentV2Response>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}