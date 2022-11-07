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
    /// AdminGetClientsbyNamespacebyIDV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [READ]'
    /// action code: 10309
    /// </summary>
    public class AdminGetClientsbyNamespacebyIDV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetClientsbyNamespacebyIDV3Builder Builder = new AdminGetClientsbyNamespacebyIDV3Builder();

        public class AdminGetClientsbyNamespacebyIDV3Builder
            : OperationBuilder<AdminGetClientsbyNamespacebyIDV3Builder>
        {





            internal AdminGetClientsbyNamespacebyIDV3Builder() { }






            public AdminGetClientsbyNamespacebyIDV3 Build(
                string clientId,
                string namespace_
            )
            {
                AdminGetClientsbyNamespacebyIDV3 op = new AdminGetClientsbyNamespacebyIDV3(this,
                    clientId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetClientsbyNamespacebyIDV3(AdminGetClientsbyNamespacebyIDV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetClientsbyNamespacebyIDV3(
            string clientId,            
            string namespace_            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ClientmodelClientV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}