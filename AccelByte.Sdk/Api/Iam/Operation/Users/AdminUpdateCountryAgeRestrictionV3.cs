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
    /// AdminUpdateCountryAgeRestrictionV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:AGERESTRICTION [UPDATE]'
    /// action code: 10123
    /// </summary>
    public class AdminUpdateCountryAgeRestrictionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateCountryAgeRestrictionV3Builder Builder = new AdminUpdateCountryAgeRestrictionV3Builder();

        public class AdminUpdateCountryAgeRestrictionV3Builder
            : OperationBuilder<AdminUpdateCountryAgeRestrictionV3Builder>
        {
            
            
            
            internal AdminUpdateCountryAgeRestrictionV3Builder() { }





            public AdminUpdateCountryAgeRestrictionV3 Build(
                ModelCountryAgeRestrictionV3Request body,
                string countryCode,
                string namespace_
            )
            {
                AdminUpdateCountryAgeRestrictionV3 op = new AdminUpdateCountryAgeRestrictionV3(this,
                    body,                    
                    countryCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateCountryAgeRestrictionV3(AdminUpdateCountryAgeRestrictionV3Builder builder,
            ModelCountryAgeRestrictionV3Request body,
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateCountryAgeRestrictionV3(
            string countryCode,            
            string namespace_,            
            Model.ModelCountryAgeRestrictionV3Request body            
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/agerestrictions/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelCountryV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelCountryV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelCountryV3Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}