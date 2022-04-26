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
    /// PublicUpgradeHeadlessAccountV4
    ///
    /// Require valid user authorization
    /// Upgrade headless account to full account without verifying email address. Client does not need to provide verification code which sent to email address.
    /// 
    /// action code : 10124
    /// </summary>
    public class PublicUpgradeHeadlessAccountV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpgradeHeadlessAccountV4Builder Builder = new PublicUpgradeHeadlessAccountV4Builder();

        public class PublicUpgradeHeadlessAccountV4Builder
            : OperationBuilder<PublicUpgradeHeadlessAccountV4Builder>
        {
            
            
            internal PublicUpgradeHeadlessAccountV4Builder() { }






            public PublicUpgradeHeadlessAccountV4 Build(
                AccountUpgradeHeadlessAccountRequestV4 body,
                string namespace_
            )
            {
                PublicUpgradeHeadlessAccountV4 op = new PublicUpgradeHeadlessAccountV4(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUpgradeHeadlessAccountV4(PublicUpgradeHeadlessAccountV4Builder builder,
            AccountUpgradeHeadlessAccountRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpgradeHeadlessAccountV4(
            string namespace_,            
            Model.AccountUpgradeHeadlessAccountRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/headless/verify";

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