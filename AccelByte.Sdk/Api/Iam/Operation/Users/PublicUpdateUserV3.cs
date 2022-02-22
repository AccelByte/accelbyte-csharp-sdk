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
    /// PublicUpdateUserV3
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
    /// Supported field {country, displayName, languageTag, dateOfBirth}
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
    ///  Several case of updating email address
    /// 
    ///                     * User want to update email address of which have been verified, newEmailAddress response field will be filled with new email address.
    /// 
    /// 
    ///                     * User want to update email address of which have not been verified, { oldEmailAddress, emailAddress} response field will be filled with new email address.
    /// 
    /// 
    ///                     * User want to update email address of which have been verified and updated before, { oldEmailAddress, emailAddress} response field will be filled with verified email before. newEmailAddress response field will be filled with newest email address.
    /// 
    /// 
    /// 
    /// action code : 10103
    /// </summary>
    public class PublicUpdateUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserV3Builder Builder = new PublicUpdateUserV3Builder();

        public class PublicUpdateUserV3Builder
        {
            
            
            internal PublicUpdateUserV3Builder() { }





            public PublicUpdateUserV3 Build(
                ModelUserUpdateRequestV3 body,
                string namespace_
            )
            {
                return new PublicUpdateUserV3(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private PublicUpdateUserV3(PublicUpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicUpdateUserV3(
            string namespace_,            
            Model.ModelUserUpdateRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelUserResponseV3>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserResponseV3>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserResponseV3>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}