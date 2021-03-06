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

namespace AccelByte.Sdk.Api.Iam.Operation.Deprecated
{
    /// <summary>
    /// UpdateClient
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'CLIENT:ADMIN [UPDATE]'
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/clients/{clientId} [PATCH]
    /// 
    /// 
    ///   * Note:
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UpdateClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateClientBuilder Builder = new UpdateClientBuilder();

        public class UpdateClientBuilder
            : OperationBuilder<UpdateClientBuilder>
        {





            internal UpdateClientBuilder() { }






            public UpdateClient Build(
                ClientmodelClientUpdateRequest body,
                string clientId
            )
            {
                UpdateClient op = new UpdateClient(this,
                    body,                    
                    clientId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateClient(UpdateClientBuilder builder,
            ClientmodelClientUpdateRequest body,
            string clientId
        )
        {
            PathParams["clientId"] = clientId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateClient(
            string clientId,            
            Model.ClientmodelClientUpdateRequest body            
        )
        {
            PathParams["clientId"] = clientId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ClientmodelClientResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}