// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateOverrideRegionOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint creates a dedicated servers deployment override in a namespace in a region for deployment overrides.
    /// </summary>
    public class CreateOverrideRegionOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateOverrideRegionOverrideBuilder Builder { get => new CreateOverrideRegionOverrideBuilder(); }

        public class CreateOverrideRegionOverrideBuilder
            : OperationBuilder<CreateOverrideRegionOverrideBuilder>
        {





            internal CreateOverrideRegionOverrideBuilder() { }






            public CreateOverrideRegionOverride Build(
                ModelsCreateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region,
                string version
            )
            {
                CreateOverrideRegionOverride op = new CreateOverrideRegionOverride(this,
                    body,
                    deployment,
                    namespace_,
                    region,
                    version
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateOverrideRegionOverride(CreateOverrideRegionOverrideBuilder builder,
            ModelsCreateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            PathParams["version"] = version;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateOverrideRegionOverride(
            string deployment,
            string namespace_,
            string region,
            string version,
            Model.ModelsCreateRegionOverrideRequest body
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            PathParams["version"] = version;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsDeploymentWithOverride? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}