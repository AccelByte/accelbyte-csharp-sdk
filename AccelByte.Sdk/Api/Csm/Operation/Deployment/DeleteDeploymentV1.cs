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
    /// DeleteDeploymentV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:DEPLOYMENT [DELETE]`
    /// 
    /// Delete Deployment information by given DeploymentID
    /// 
    /// This endpoint intended to delete helm release object and update the deleted_at in DB by given Deployment ID.
    /// 
    /// Required: Valid Access Token
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteDeploymentV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteDeploymentV1Builder Builder { get => new DeleteDeploymentV1Builder(); }

        public class DeleteDeploymentV1Builder
            : OperationBuilder<DeleteDeploymentV1Builder>
        {





            internal DeleteDeploymentV1Builder() { }






            public DeleteDeploymentV1 Build(
                string deploymentId,
                string namespace_
            )
            {
                DeleteDeploymentV1 op = new DeleteDeploymentV1(this,
                    deploymentId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteDeploymentV1(DeleteDeploymentV1Builder builder,
            string deploymentId,
            string namespace_
        )
        {
            PathParams["deploymentId"] = deploymentId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteDeploymentV1(
            string deploymentId,
            string namespace_
        )
        {
            PathParams["deploymentId"] = deploymentId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/deployments/{deploymentId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

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