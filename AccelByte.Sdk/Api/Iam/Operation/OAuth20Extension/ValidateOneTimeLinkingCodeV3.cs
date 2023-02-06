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
    /// ValidateOneTimeLinkingCodeV3
    ///
    /// This endpoint is being used to validate one time link code.
    /// 
    /// It require a valid user token.
    /// 
    /// Should specify the target platform id and current user should already linked to this platform.
    /// 
    /// Current user should be a headless account.
    /// </summary>
    public class ValidateOneTimeLinkingCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ValidateOneTimeLinkingCodeV3Builder Builder { get => new ValidateOneTimeLinkingCodeV3Builder(); }

        public class ValidateOneTimeLinkingCodeV3Builder
            : OperationBuilder<ValidateOneTimeLinkingCodeV3Builder>
        {





            internal ValidateOneTimeLinkingCodeV3Builder() { }






            public ValidateOneTimeLinkingCodeV3 Build(
                string oneTimeLinkCode
            )
            {
                ValidateOneTimeLinkingCodeV3 op = new ValidateOneTimeLinkingCodeV3(this,
                    oneTimeLinkCode                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ValidateOneTimeLinkingCodeV3(ValidateOneTimeLinkingCodeV3Builder builder,
            string oneTimeLinkCode
        )
        {
            
            
            if (oneTimeLinkCode is not null) FormParams["oneTimeLinkCode"] = oneTimeLinkCode;

            
            
            

        }
        #endregion

        public ValidateOneTimeLinkingCodeV3(
            string oneTimeLinkCode            
        )
        {
            
            
            if (oneTimeLinkCode is not null) FormParams["oneTimeLinkCode"] = oneTimeLinkCode;

            
            
            

        }

        public override string Path => "/iam/v3/link/code/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthmodelOneTimeLinkingCodeValidationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeValidationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeValidationResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}