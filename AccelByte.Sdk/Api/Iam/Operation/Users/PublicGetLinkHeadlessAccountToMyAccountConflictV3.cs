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
    /// PublicGetLinkHeadlessAccountToMyAccountConflictV3
    ///
    /// Note:
    /// 
    /// 1. My account should be full account
    /// 2. My account not linked to request headless account's third platform.
    /// </summary>
    public class PublicGetLinkHeadlessAccountToMyAccountConflictV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder Builder { get => new PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder(); }

        public class PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder
            : OperationBuilder<PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder>
        {





            internal PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder() { }






            public PublicGetLinkHeadlessAccountToMyAccountConflictV3 Build(
                string oneTimeLinkCode
            )
            {
                PublicGetLinkHeadlessAccountToMyAccountConflictV3 op = new PublicGetLinkHeadlessAccountToMyAccountConflictV3(this,
                    oneTimeLinkCode                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetLinkHeadlessAccountToMyAccountConflictV3(PublicGetLinkHeadlessAccountToMyAccountConflictV3Builder builder,
            string oneTimeLinkCode
        )
        {
            
            if (oneTimeLinkCode is not null) QueryParams["oneTimeLinkCode"] = oneTimeLinkCode;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetLinkHeadlessAccountToMyAccountConflictV3(
            string oneTimeLinkCode            
        )
        {
            
            if (oneTimeLinkCode is not null) QueryParams["oneTimeLinkCode"] = oneTimeLinkCode;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me/headless/link/conflict";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelGetLinkHeadlessAccountConflictResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetLinkHeadlessAccountConflictResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetLinkHeadlessAccountConflictResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}