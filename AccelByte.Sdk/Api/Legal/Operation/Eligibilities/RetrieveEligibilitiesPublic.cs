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
    /// retrieveEligibilitiesPublic
    ///
    /// Retrieve the active policies and its conformance status by user.
    /// This process supports cross-namespace checking, that means if the active policy already accepted by the same user in other namespace, then it will be considered as eligible.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class RetrieveEligibilitiesPublic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveEligibilitiesPublicBuilder Builder = new RetrieveEligibilitiesPublicBuilder();

        public class RetrieveEligibilitiesPublicBuilder
        {
            
            internal RetrieveEligibilitiesPublicBuilder() { }





            public RetrieveEligibilitiesPublic Build(
                string namespace_
            )
            {
                return new RetrieveEligibilitiesPublic(this,
                    namespace_                    
                );
            }
        }

        private RetrieveEligibilitiesPublic(RetrieveEligibilitiesPublicBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public RetrieveEligibilitiesPublic(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/agreement/public/eligibilities/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.RetrieveUserEligibilitiesResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveUserEligibilitiesResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveUserEligibilitiesResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}