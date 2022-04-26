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
    /// AdminGetBulkUserByEmailAddressV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint search user by the list of email addresses
    /// 
    /// 
    /// 
    /// action code : 10132
    /// </summary>
    public class AdminGetBulkUserByEmailAddressV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBulkUserByEmailAddressV3Builder Builder = new AdminGetBulkUserByEmailAddressV3Builder();

        public class AdminGetBulkUserByEmailAddressV3Builder
            : OperationBuilder<AdminGetBulkUserByEmailAddressV3Builder>
        {
            
            
            internal AdminGetBulkUserByEmailAddressV3Builder() { }






            public AdminGetBulkUserByEmailAddressV3 Build(
                ModelListEmailAddressRequest body,
                string namespace_
            )
            {
                AdminGetBulkUserByEmailAddressV3 op = new AdminGetBulkUserByEmailAddressV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetBulkUserByEmailAddressV3(AdminGetBulkUserByEmailAddressV3Builder builder,
            ModelListEmailAddressRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetBulkUserByEmailAddressV3(
            string namespace_,            
            Model.ModelListEmailAddressRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/search/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelListUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}