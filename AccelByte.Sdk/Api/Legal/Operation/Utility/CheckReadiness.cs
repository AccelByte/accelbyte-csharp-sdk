// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// checkReadiness
    ///
    /// Readiness status defined as at least one legal basePolicy is present and having active basePolicy.
    /// Other detail info:
    ///     * Required permission : resource="NAMESPACE:{namespace}:LEGAL", action=2 (READ)
    /// </summary>
    public class CheckReadiness : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckReadinessBuilder Builder = new CheckReadinessBuilder();

        public class CheckReadinessBuilder
            : OperationBuilder<CheckReadinessBuilder>
        {
            internal CheckReadinessBuilder() { }





            public CheckReadiness Build(
            )
            {
                CheckReadiness op = new CheckReadiness(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CheckReadiness(CheckReadinessBuilder builder
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CheckReadiness(
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/readiness";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.LegalReadinessStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.LegalReadinessStatusResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.LegalReadinessStatusResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}