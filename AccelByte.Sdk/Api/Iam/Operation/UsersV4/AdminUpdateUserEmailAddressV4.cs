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
    /// AdminUpdateUserEmailAddressV4
    ///
    /// 
    /// 
    /// Required permission
    /// 
    ///                                                                                                 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This is the endpoint for an admin to update a user email address.
    /// This endpoint need a valid user token from an admin to verify its identity (email) before updating a user.
    /// </summary>
    public class AdminUpdateUserEmailAddressV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserEmailAddressV4Builder Builder = new AdminUpdateUserEmailAddressV4Builder();

        public class AdminUpdateUserEmailAddressV4Builder
            : OperationBuilder<AdminUpdateUserEmailAddressV4Builder>
        {
            
            
            
            internal AdminUpdateUserEmailAddressV4Builder() { }






            public AdminUpdateUserEmailAddressV4 Build(
                ModelEmailUpdateRequestV4 body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserEmailAddressV4 op = new AdminUpdateUserEmailAddressV4(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateUserEmailAddressV4(AdminUpdateUserEmailAddressV4Builder builder,
            ModelEmailUpdateRequestV4 body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateUserEmailAddressV4(
            string namespace_,            
            string userId,            
            Model.ModelEmailUpdateRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/email";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}