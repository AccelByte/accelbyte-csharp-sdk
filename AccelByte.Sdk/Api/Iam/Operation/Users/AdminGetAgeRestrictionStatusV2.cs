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
    /// AdminGetAgeRestrictionStatusV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:AGERESTRICTION [READ]'
    /// </summary>
    public class AdminGetAgeRestrictionStatusV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetAgeRestrictionStatusV2Builder Builder = new AdminGetAgeRestrictionStatusV2Builder();

        public class AdminGetAgeRestrictionStatusV2Builder
        {
            
            internal AdminGetAgeRestrictionStatusV2Builder() { }





            public AdminGetAgeRestrictionStatusV2 Build(
                string namespace_
            )
            {
                return new AdminGetAgeRestrictionStatusV2(this,
                    namespace_                    
                );
            }
        }

        private AdminGetAgeRestrictionStatusV2(AdminGetAgeRestrictionStatusV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public AdminGetAgeRestrictionStatusV2(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/agerestrictions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelAgeRestrictionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelAgeRestrictionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAgeRestrictionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}