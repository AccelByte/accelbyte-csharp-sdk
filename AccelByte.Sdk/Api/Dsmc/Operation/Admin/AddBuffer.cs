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
    /// AddBuffer
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint manually adds buffer for selected namespace and deployment
    /// x Job will contain y num of allocs.
    /// 
    /// Region can be filled with comma-separated values.
    /// use * as region name to deploy to all region specified in the deployment's region list
    /// 
    /// if JobPriority set to 0, we will use 80 as default value for job priority
    /// 
    /// OverrideVersion will be used as override version for the new allocations.
    /// If OverrideVersion is empty, will use version in the deployment.
    /// ```
    /// </summary>
    public class AddBuffer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddBufferBuilder Builder { get => new AddBufferBuilder(); }

        public class AddBufferBuilder
            : OperationBuilder<AddBufferBuilder>
        {





            internal AddBufferBuilder() { }






            public AddBuffer Build(
                ModelsAddBufferRequest body,
                string namespace_
            )
            {
                AddBuffer op = new AddBuffer(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AddBuffer(AddBufferBuilder builder,
            ModelsAddBufferRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddBuffer(
            string namespace_,
            Model.ModelsAddBufferRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/manual/buffer/add";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsAddBufferResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsAddBufferResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsAddBufferResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAddBufferResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}