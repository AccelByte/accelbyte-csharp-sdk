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
    /// AdminUpdateUserV2
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// This Endpoint support update user based on given data. Single request can update single field or multi fields.
    /// 
    /// Supported field {Country, DisplayName, LanguageTag}
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// 
    ///  Several case of updating email address
    ///         * User want to update email address of which have been verified, NewEmailAddress response field will be filled with new email address.
    ///         * User want to update email address of which have not been verified, {LoginId, OldEmailAddress, EmailAddress} response field will be filled with new email address.
    ///         * User want to update email address of which have been verified and updated before, {LoginId, OldEmailAddress, EmailAddress} response field will be filled with verified email before. NewEmailAddress response field will be filled with newest email address.
    /// </summary>
    public class AdminUpdateUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserV2Builder Builder = new AdminUpdateUserV2Builder();

        public class AdminUpdateUserV2Builder
        {
            
            
            
            internal AdminUpdateUserV2Builder() { }





            public AdminUpdateUserV2 Build(
                ModelUserUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                return new AdminUpdateUserV2(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminUpdateUserV2(AdminUpdateUserV2Builder builder,
            ModelUserUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdateUserV2(
            string namespace_,            
            string userId,            
            Model.ModelUserUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}