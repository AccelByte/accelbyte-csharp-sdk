// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminDeleteType
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:UGCCONFIG [DELETE]
    /// </summary>
    public class AdminDeleteType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteTypeBuilder Builder = new AdminDeleteTypeBuilder();

        public class AdminDeleteTypeBuilder
            : OperationBuilder<AdminDeleteTypeBuilder>
        {
            
            
            internal AdminDeleteTypeBuilder() { }






            public AdminDeleteType Build(
                string namespace_,
                string typeId
            )
            {
                AdminDeleteType op = new AdminDeleteType(this,
                    namespace_,                    
                    typeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteType(AdminDeleteTypeBuilder builder,
            string namespace_,
            string typeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["typeId"] = typeId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteType(
            string namespace_,            
            string typeId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["typeId"] = typeId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/types/{typeId}";

        public override HttpMethod Method => HttpMethod.Delete;

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