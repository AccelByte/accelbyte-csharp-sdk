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
    /// GetClient
    ///
    /// Required permission 'CLIENT [READ]'
    /// </summary>
    public class GetClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetClientBuilder Builder = new GetClientBuilder();

        public class GetClientBuilder
        {
            
            internal GetClientBuilder() { }





            public GetClient Build(
                string clientId
            )
            {
                return new GetClient(this,
                    clientId                    
                );
            }
        }

        private GetClient(GetClientBuilder builder,
            string clientId
        )
        {
            PathParams["clientId"] = clientId;
            
            
            
            
            
        }
        #endregion

        public GetClient(
            string clientId            
        )
        {
            PathParams["clientId"] = clientId;
            
            
            
            
            
        }

        public override string Path => "/iam/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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