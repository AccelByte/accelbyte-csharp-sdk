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
    /// AdminGetListCountryAgeRestrictionV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:AGERESTRICTION [READ]
    /// action code : 10139
    /// </summary>
    public class AdminGetListCountryAgeRestrictionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListCountryAgeRestrictionV3Builder Builder { get => new AdminGetListCountryAgeRestrictionV3Builder(); }

        public class AdminGetListCountryAgeRestrictionV3Builder
            : OperationBuilder<AdminGetListCountryAgeRestrictionV3Builder>
        {





            internal AdminGetListCountryAgeRestrictionV3Builder() { }






            public AdminGetListCountryAgeRestrictionV3 Build(
                string namespace_
            )
            {
                AdminGetListCountryAgeRestrictionV3 op = new AdminGetListCountryAgeRestrictionV3(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetListCountryAgeRestrictionV3(AdminGetListCountryAgeRestrictionV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetListCountryAgeRestrictionV3(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/agerestrictions/countries";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ModelCountryV3Response>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelCountryV3Response>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelCountryV3Response>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}