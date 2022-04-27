// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// anonymizeUserAgreement
    ///
    /// This API will anonymize agreement record for specified user. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=8 (DELETE)
    /// </summary>
    public class AnonymizeUserAgreement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AnonymizeUserAgreementBuilder Builder = new AnonymizeUserAgreementBuilder();

        public class AnonymizeUserAgreementBuilder
            : OperationBuilder<AnonymizeUserAgreementBuilder>
        {
            
            internal AnonymizeUserAgreementBuilder() { }






            public AnonymizeUserAgreement Build(
                string userId
            )
            {
                AnonymizeUserAgreement op = new AnonymizeUserAgreement(this,
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AnonymizeUserAgreement(AnonymizeUserAgreementBuilder builder,
            string userId
        )
        {
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AnonymizeUserAgreement(
            string userId            
        )
        {
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/users/{userId}/anonymization/agreements";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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