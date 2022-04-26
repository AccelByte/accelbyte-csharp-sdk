// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// CreateClient
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated at 16 August, 2018. Please use this instead: namespaces/{namespace}/clients
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'CLIENT:ADMIN [CREATE]'
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class CreateClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateClientBuilder Builder = new CreateClientBuilder();

        public class CreateClientBuilder
            : OperationBuilder<CreateClientBuilder>
        {
            
            internal CreateClientBuilder() { }






            public CreateClient Build(
                ClientmodelClientCreateRequest body
            )
            {
                CreateClient op = new CreateClient(this,
                    body                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateClient(CreateClientBuilder builder,
            ClientmodelClientCreateRequest body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateClient(
            Model.ClientmodelClientCreateRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
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