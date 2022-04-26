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
    /// AdminDeleteClientV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [DELETE]'
    /// action code : 10310
    /// </summary>
    public class AdminDeleteClientV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteClientV3Builder Builder = new AdminDeleteClientV3Builder();

        public class AdminDeleteClientV3Builder
            : OperationBuilder<AdminDeleteClientV3Builder>
        {
            
            
            internal AdminDeleteClientV3Builder() { }






            public AdminDeleteClientV3 Build(
                string clientId,
                string namespace_
            )
            {
                AdminDeleteClientV3 op = new AdminDeleteClientV3(this,
                    clientId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteClientV3(AdminDeleteClientV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteClientV3(
            string clientId,            
            string namespace_            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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