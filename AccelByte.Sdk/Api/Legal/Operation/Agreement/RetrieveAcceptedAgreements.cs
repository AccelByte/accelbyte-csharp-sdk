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
    /// retrieveAcceptedAgreements
    ///
    /// This API will return all accepted Legal Agreements for specified user. Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveAcceptedAgreements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAcceptedAgreementsBuilder Builder = new RetrieveAcceptedAgreementsBuilder();

        public class RetrieveAcceptedAgreementsBuilder
            : OperationBuilder<RetrieveAcceptedAgreementsBuilder>
        {
            
            internal RetrieveAcceptedAgreementsBuilder() { }





            public RetrieveAcceptedAgreements Build(
                string userId
            )
            {
                RetrieveAcceptedAgreements op = new RetrieveAcceptedAgreements(this,
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveAcceptedAgreements(RetrieveAcceptedAgreementsBuilder builder,
            string userId
        )
        {
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAcceptedAgreements(
            string userId            
        )
        {
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/agreements/policies/users/{userId}";

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