// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// handlerV3Healthz
    /// </summary>
    public class HandlerV3Healthz : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static HandlerV3HealthzBuilder Builder = new HandlerV3HealthzBuilder();

        public class HandlerV3HealthzBuilder
        {
            internal HandlerV3HealthzBuilder() { }





            public HandlerV3Healthz Build(
            )
            {
                return new HandlerV3Healthz(this
                );
            }
        }

        private HandlerV3Healthz(HandlerV3HealthzBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public HandlerV3Healthz(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/matchmaking/healthz";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}