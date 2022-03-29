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
    /// AdminUpdateMyUserV4
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This Endpoint support update user based on given data. Single request can update single field or multi fields.
    /// 
    /// 
    /// 
    /// 
    /// Supported field {country, displayName, languageTag, dateOfBirth, userName}
    /// 
    /// 
    /// 
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// 
    /// 
    /// 
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// 
    /// 
    /// 
    /// 
    /// action code : 10103
    /// </summary>
    public class AdminUpdateMyUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateMyUserV4Builder Builder = new AdminUpdateMyUserV4Builder();

        public class AdminUpdateMyUserV4Builder
        {
            
            internal AdminUpdateMyUserV4Builder() { }





            public AdminUpdateMyUserV4 Build(
                ModelUserUpdateRequestV3 body
            )
            {
                return new AdminUpdateMyUserV4(this,
                    body                    
                );
            }
        }

        private AdminUpdateMyUserV4(AdminUpdateMyUserV4Builder builder,
            ModelUserUpdateRequestV3 body
        )
        {
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdateMyUserV4(
            Model.ModelUserUpdateRequestV3 body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/users/me";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}