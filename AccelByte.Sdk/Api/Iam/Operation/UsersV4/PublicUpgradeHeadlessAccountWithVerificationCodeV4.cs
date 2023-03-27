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
    /// PublicUpgradeHeadlessAccountWithVerificationCodeV4
    ///
    /// Require valid user access token.
    /// The endpoint upgrades a headless account by linking the headless account with the email address, username, and password.
    /// By upgrading the headless account into a full account, the user could use the email address, username, and password for using Justice IAM.
    /// 
    /// 
    /// The endpoint is a shortcut for upgrading a headless account and verifying the email address in one call.
    /// In order to get a verification code for the endpoint, please check the send verification code endpoint.
    /// 
    /// 
    /// This endpoint also have an ability to update user data (if the user data field is specified) right after the upgrade account process is done.
    /// Supported user data fields:
    /// 
    /// 
    ///                           * displayName
    /// 
    /// 
    ///                           * dateOfBirth : format YYYY-MM-DD, e.g. 2019-04-29
    /// 
    /// 
    ///                           * country : format ISO3166-1 alpha-2 two letter, e.g. US
    /// 
    /// 
    /// action code : 10124
    /// </summary>
    public class PublicUpgradeHeadlessAccountWithVerificationCodeV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder Builder { get => new PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder(); }

        public class PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder
            : OperationBuilder<PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder>
        {





            internal PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder() { }






            public PublicUpgradeHeadlessAccountWithVerificationCodeV4 Build(
                AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4 body,
                string namespace_
            )
            {
                PublicUpgradeHeadlessAccountWithVerificationCodeV4 op = new PublicUpgradeHeadlessAccountWithVerificationCodeV4(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUpgradeHeadlessAccountWithVerificationCodeV4(PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder builder,
            AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpgradeHeadlessAccountWithVerificationCodeV4(
            string namespace_,            
            Model.AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/headless/code/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AccountUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountUserResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountUserResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}