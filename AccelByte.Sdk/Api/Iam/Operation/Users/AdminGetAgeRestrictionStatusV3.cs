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
    /// AdminGetAgeRestrictionStatusV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:AGERESTRICTION [READ]'
    /// action code: 10138
    /// </summary>
    public class AdminGetAgeRestrictionStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetAgeRestrictionStatusV3Builder Builder = new AdminGetAgeRestrictionStatusV3Builder();

        public class AdminGetAgeRestrictionStatusV3Builder
            : OperationBuilder<AdminGetAgeRestrictionStatusV3Builder>
        {
            
            internal AdminGetAgeRestrictionStatusV3Builder() { }





            public AdminGetAgeRestrictionStatusV3 Build(
                string namespace_
            )
            {
                AdminGetAgeRestrictionStatusV3 op = new AdminGetAgeRestrictionStatusV3(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetAgeRestrictionStatusV3(AdminGetAgeRestrictionStatusV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetAgeRestrictionStatusV3(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/agerestrictions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelAgeRestrictionResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelAgeRestrictionResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAgeRestrictionResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}