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
    /// AdminUpdateType
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:UGCCONFIG [UPDATE]
    /// updates a type and subtype
    /// </summary>
    public class AdminUpdateType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateTypeBuilder Builder = new AdminUpdateTypeBuilder();

        public class AdminUpdateTypeBuilder
            : OperationBuilder<AdminUpdateTypeBuilder>
        {
            
            
            
            internal AdminUpdateTypeBuilder() { }





            public AdminUpdateType Build(
                ModelsCreateTypeRequest body,
                string namespace_,
                string typeId
            )
            {
                AdminUpdateType op = new AdminUpdateType(this,
                    body,                    
                    namespace_,                    
                    typeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateType(AdminUpdateTypeBuilder builder,
            ModelsCreateTypeRequest body,
            string namespace_,
            string typeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["typeId"] = typeId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateType(
            string namespace_,            
            string typeId,            
            Model.ModelsCreateTypeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["typeId"] = typeId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/types/{typeId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsCreateTypeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateTypeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateTypeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}