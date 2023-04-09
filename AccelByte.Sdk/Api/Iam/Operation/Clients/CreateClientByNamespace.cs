// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// CreateClientByNamespace
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [CREATE]'
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /v3/admin/namespaces/{namespace}/clients [POST]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class CreateClientByNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateClientByNamespaceBuilder Builder { get => new CreateClientByNamespaceBuilder(); }

        public class CreateClientByNamespaceBuilder
            : OperationBuilder<CreateClientByNamespaceBuilder>
        {





            internal CreateClientByNamespaceBuilder() { }






            public CreateClientByNamespace Build(
                ClientmodelClientCreateRequest body,
                string namespace_
            )
            {
                CreateClientByNamespace op = new CreateClientByNamespace(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateClientByNamespace(CreateClientByNamespaceBuilder builder,
            ClientmodelClientCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateClientByNamespace(
            string namespace_,
            Model.ClientmodelClientCreateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/clients";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ClientmodelClientCreationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientCreationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientCreationResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}