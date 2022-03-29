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
    /// updateLocalizedPolicyVersion
    ///
    /// Update a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class UpdateLocalizedPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateLocalizedPolicyVersionBuilder Builder = new UpdateLocalizedPolicyVersionBuilder();

        public class UpdateLocalizedPolicyVersionBuilder
        {
            
            public Model.UpdateLocalizedPolicyVersionRequest? Body { get; set; }
            
            internal UpdateLocalizedPolicyVersionBuilder() { }



            public UpdateLocalizedPolicyVersionBuilder SetBody(Model.UpdateLocalizedPolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }



            public UpdateLocalizedPolicyVersion Build(
                string localizedPolicyVersionId
            )
            {
                return new UpdateLocalizedPolicyVersion(this,
                    localizedPolicyVersionId                    
                );
            }
        }

        private UpdateLocalizedPolicyVersion(UpdateLocalizedPolicyVersionBuilder builder,
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateLocalizedPolicyVersion(
            string localizedPolicyVersionId,            
            Model.UpdateLocalizedPolicyVersionRequest body            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UpdateLocalizedPolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UpdateLocalizedPolicyVersionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdateLocalizedPolicyVersionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}