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
    /// versionCheckHandler
    /// </summary>
    public class VersionCheckHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static VersionCheckHandlerBuilder Builder = new VersionCheckHandlerBuilder();

        public class VersionCheckHandlerBuilder
        {
            internal VersionCheckHandlerBuilder() { }





            public VersionCheckHandler Build(
            )
            {
                return new VersionCheckHandler(this
                );
            }
        }

        private VersionCheckHandler(VersionCheckHandlerBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public VersionCheckHandler(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/matchmaking/version";

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