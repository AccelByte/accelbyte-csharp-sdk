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
    /// createGroupConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [CREATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to create new configuration. Before creating the configuration, make sure that member role for admin and group member are already created before.
    /// 
    /// 
    /// 
    /// 
    /// For each of the global rule, it will be the rule detail that consists of these fields:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * ruleAttribute : attribute of the player that needs to be checked
    /// 
    /// 
    ///   * ruleCriteria : criteria of the value. The value will be in enum of EQUAL, MINIMUM, MAXIMUM
    /// 
    /// 
    ///   * ruleValue : value that needs to be checked
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Allowed Action can only be filled with any available action in the Group Service. For the configuration, the only value is "createGroup"
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73103
    /// </summary>
    public class CreateGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public CreateGroupConfigurationAdminV1(
            string namespace_,            
            Model.ModelsCreateGroupConfigurationRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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