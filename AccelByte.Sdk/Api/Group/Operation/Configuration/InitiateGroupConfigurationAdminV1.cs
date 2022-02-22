// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// initiateGroupConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [CREATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to initiate configuration. This endpoint will automatically create default configuration and member roles with default permission
    /// 
    /// 
    /// 
    /// 
    /// Default Permission for admin role will cover these permission:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * Permission to invite user to group
    /// 
    /// 
    ///   * Permission to accept or reject join request
    /// 
    /// 
    ///   * Permission to kick group member
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Default max member value will be 50 and global rules will be empty
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73104
    /// </summary>
    public class InitiateGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static InitiateGroupConfigurationAdminV1Builder Builder = new InitiateGroupConfigurationAdminV1Builder();

        public class InitiateGroupConfigurationAdminV1Builder
        {
            
            internal InitiateGroupConfigurationAdminV1Builder() { }





            public InitiateGroupConfigurationAdminV1 Build(
                string namespace_
            )
            {
                return new InitiateGroupConfigurationAdminV1(this,
                    namespace_                    
                );
            }
        }

        private InitiateGroupConfigurationAdminV1(InitiateGroupConfigurationAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public InitiateGroupConfigurationAdminV1(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/initiate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupConfigurationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupConfigurationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}