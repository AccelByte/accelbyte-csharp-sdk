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
    /// DeleteClientByNamespace
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT:{clientId} [DELETE]'
    /// </summary>
    public class DeleteClientByNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteClientByNamespaceBuilder Builder = new DeleteClientByNamespaceBuilder();

        public class DeleteClientByNamespaceBuilder
        {
            
            
            internal DeleteClientByNamespaceBuilder() { }





            public DeleteClientByNamespace Build(
                string clientId,
                string namespace_
            )
            {
                return new DeleteClientByNamespace(this,
                    clientId,                    
                    namespace_                    
                );
            }
        }

        private DeleteClientByNamespace(DeleteClientByNamespaceBuilder builder,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public DeleteClientByNamespace(
            string clientId,            
            string namespace_            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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