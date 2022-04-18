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
    /// GetClients
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated at 10 August, 2018. Please use this instead: namespaces/{namespace}/clients
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'CLIENT [READ]'
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetClients : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetClientsBuilder Builder = new GetClientsBuilder();

        public class GetClientsBuilder
            : OperationBuilder<GetClientsBuilder>
        {
            internal GetClientsBuilder() { }





            public GetClients Build(
            )
            {
                GetClients op = new GetClients(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetClients(GetClientsBuilder builder
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetClients(
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ClientmodelClientResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ClientmodelClientResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ClientmodelClientResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}