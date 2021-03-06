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
    /// AdminUpdateUserV4
    ///
    /// 
    /// 
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE] permission
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
    /// 
    /// action code : 10103
    /// </summary>
    public class AdminUpdateUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserV4Builder Builder = new AdminUpdateUserV4Builder();

        public class AdminUpdateUserV4Builder
            : OperationBuilder<AdminUpdateUserV4Builder>
        {





            internal AdminUpdateUserV4Builder() { }






            public AdminUpdateUserV4 Build(
                ModelUserUpdateRequestV3 body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserV4 op = new AdminUpdateUserV4(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateUserV4(AdminUpdateUserV4Builder builder,
            ModelUserUpdateRequestV3 body,
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

        public AdminUpdateUserV4(
            string namespace_,            
            string userId,            
            Model.ModelUserUpdateRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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