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
    /// DeleteClient
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated at 16 August, 2018. Please use this instead: namespaces/{namespace}/clients/{clientId}
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'CLIENT:ADMIN [DELETE]'
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DeleteClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteClientBuilder Builder = new DeleteClientBuilder();

        public class DeleteClientBuilder
        {
            
            internal DeleteClientBuilder() { }





            public DeleteClient Build(
                string clientId
            )
            {
                return new DeleteClient(this,
                    clientId                    
                );
            }
        }

        private DeleteClient(DeleteClientBuilder builder,
            string clientId
        )
        {
            PathParams["clientId"] = clientId;
            
            
            
            
            
        }
        #endregion

        public DeleteClient(
            string clientId            
        )
        {
            PathParams["clientId"] = clientId;
            
            
            
            
            
        }

        public override string Path => "/iam/clients/{clientId}";

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