// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetCountryAgeRestriction
    ///
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /iam/v3/public/namespaces/{namespace}/agerestrictions/countries/{countryCode} [GET]
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class PublicGetCountryAgeRestriction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCountryAgeRestrictionBuilder Builder { get => new PublicGetCountryAgeRestrictionBuilder(); }

        public class PublicGetCountryAgeRestrictionBuilder
            : OperationBuilder<PublicGetCountryAgeRestrictionBuilder>
        {





            internal PublicGetCountryAgeRestrictionBuilder() { }






            public PublicGetCountryAgeRestriction Build(
                string countryCode,
                string namespace_
            )
            {
                PublicGetCountryAgeRestriction op = new PublicGetCountryAgeRestriction(this,
                    countryCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetCountryAgeRestriction(PublicGetCountryAgeRestrictionBuilder builder,
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetCountryAgeRestriction(
            string countryCode,            
            string namespace_            
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/countries/{countryCode}/agerestrictions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AccountcommonCountry? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonCountry>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonCountry>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}