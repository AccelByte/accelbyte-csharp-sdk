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
    /// retrieveAgreementsPublic
    ///
    /// Retrieve accepted Legal Agreements.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class RetrieveAgreementsPublic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAgreementsPublicBuilder Builder = new RetrieveAgreementsPublicBuilder();

        public class RetrieveAgreementsPublicBuilder
            : OperationBuilder<RetrieveAgreementsPublicBuilder>
        {
            internal RetrieveAgreementsPublicBuilder() { }





            public RetrieveAgreementsPublic Build(
            )
            {
                RetrieveAgreementsPublic op = new RetrieveAgreementsPublic(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveAgreementsPublic(RetrieveAgreementsPublicBuilder builder
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAgreementsPublic(
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/policies";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.RetrieveAcceptedAgreementResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveAcceptedAgreementResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveAcceptedAgreementResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}