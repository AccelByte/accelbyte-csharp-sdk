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
    /// PublicUpgradeHeadlessAccountV3
    ///
    /// 
    /// 
    /// If validateOnly is set false, consume code and upgrade headless account and automatically verified the email address if it is succeeded
    /// 
    /// 
    /// Require valid user access token.
    /// 
    /// 
    /// The endpoint upgrades a headless account by linking the headless account with the email address and the password.
    /// By upgrading the headless account into a full account, the user could use the email address and password for using Justice IAM.
    /// 
    /// 
    /// 
    /// 
    /// The endpoint is a shortcut for upgrading a headless account and verifying the email address in one call.
    /// In order to get a verification code for the endpoint, please check the send verification code endpoint.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint also have an ability to update user data (if the user data field is specified) right after the upgrade account process is done.
    /// 
    /// Supported user data fields :
    /// 
    /// 
    ///                       * displayName
    /// 
    /// 
    ///                       * dateOfBirth : format YYYY-MM-DD, e.g. 2019-04-29
    /// 
    /// 
    ///                       * country : format ISO3166-1 alpha-2 two letter, e.g. US
    /// 
    /// 
    /// 
    /// action code : 10124
    /// </summary>
    public class PublicUpgradeHeadlessAccountV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpgradeHeadlessAccountV3Builder Builder = new PublicUpgradeHeadlessAccountV3Builder();

        public class PublicUpgradeHeadlessAccountV3Builder
        {
            
            
            internal PublicUpgradeHeadlessAccountV3Builder() { }





            public PublicUpgradeHeadlessAccountV3 Build(
                ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
                string namespace_
            )
            {
                return new PublicUpgradeHeadlessAccountV3(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private PublicUpgradeHeadlessAccountV3(PublicUpgradeHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PublicUpgradeHeadlessAccountV3(
            string namespace_,            
            Model.ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/headless/code/verify";

        public override HttpMethod Method => HttpMethod.Post;

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