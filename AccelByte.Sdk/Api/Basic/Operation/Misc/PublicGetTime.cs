// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetTime
    ///
    /// Get server time
    /// </summary>
    public class PublicGetTime : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetTimeBuilder Builder = new PublicGetTimeBuilder();

        public class PublicGetTimeBuilder
            : OperationBuilder<PublicGetTimeBuilder>
        {
            internal PublicGetTimeBuilder() { }





            public PublicGetTime Build(
            )
            {
                PublicGetTime op = new PublicGetTime(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetTime(PublicGetTimeBuilder builder
        )
        {
            
            
            
            
            

        }
        #endregion

        public PublicGetTime(
        )
        {
            
            
            
            
            

        }

        public override string Path => "/basic/v1/public/misc/time";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.RetrieveTimeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrieveTimeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveTimeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}