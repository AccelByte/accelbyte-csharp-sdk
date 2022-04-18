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
    /// AdminUpdateUserBanV3
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId}
    /// [UPDATE]
    /// Set ban status for a single user for a specific ban. Retrieve
    /// user ban and choose the ban ID. Set the form parameter to true/false to enable
    /// or disable the ban.
    /// action code : 10142'
    /// </summary>
    public class AdminUpdateUserBanV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserBanV3Builder Builder = new AdminUpdateUserBanV3Builder();

        public class AdminUpdateUserBanV3Builder
            : OperationBuilder<AdminUpdateUserBanV3Builder>
        {
            
            
            
            
            internal AdminUpdateUserBanV3Builder() { }





            public AdminUpdateUserBanV3 Build(
                ModelBanUpdateRequest body,
                string banId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserBanV3 op = new AdminUpdateUserBanV3(this,
                    body,                    
                    banId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateUserBanV3(AdminUpdateUserBanV3Builder builder,
            ModelBanUpdateRequest body,
            string banId,
            string namespace_,
            string userId
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateUserBanV3(
            string banId,            
            string namespace_,            
            string userId,            
            Model.ModelBanUpdateRequest body            
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/bans/{banId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelUserBanResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}