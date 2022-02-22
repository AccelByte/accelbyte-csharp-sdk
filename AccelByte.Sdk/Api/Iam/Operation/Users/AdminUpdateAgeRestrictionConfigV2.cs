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
    /// AdminUpdateAgeRestrictionConfigV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:AGERESTRICTION [UPDATE]'
    /// </summary>
    public class AdminUpdateAgeRestrictionConfigV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateAgeRestrictionConfigV2Builder Builder = new AdminUpdateAgeRestrictionConfigV2Builder();

        public class AdminUpdateAgeRestrictionConfigV2Builder
        {
            
            
            internal AdminUpdateAgeRestrictionConfigV2Builder() { }





            public AdminUpdateAgeRestrictionConfigV2 Build(
                ModelAgeRestrictionRequest body,
                string namespace_
            )
            {
                return new AdminUpdateAgeRestrictionConfigV2(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private AdminUpdateAgeRestrictionConfigV2(AdminUpdateAgeRestrictionConfigV2Builder builder,
            ModelAgeRestrictionRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdateAgeRestrictionConfigV2(
            string namespace_,            
            Model.ModelAgeRestrictionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/agerestrictions";

        public override HttpMethod Method => HttpMethod.Patch;

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