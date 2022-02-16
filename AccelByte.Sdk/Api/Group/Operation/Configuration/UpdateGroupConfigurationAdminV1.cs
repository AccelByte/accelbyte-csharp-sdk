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
    /// updateGroupConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update existing configuration. groupAdminRoleId and groupMemberRoleId won't be able to be updated. User can try to change the member role permission instead for each of those member role
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73102
    /// </summary>
    public class UpdateGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public UpdateGroupConfigurationAdminV1(
            string configurationCode,            
            string namespace_,            
            Model.ModelsUpdateGroupConfigurationRequestV1 body            
        )
        {
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsUpdateGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}