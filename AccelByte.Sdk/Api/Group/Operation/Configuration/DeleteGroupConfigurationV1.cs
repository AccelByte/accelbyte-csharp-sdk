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
    /// deleteGroupConfigurationV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [DELETE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to delete group configuration. This Configuration is used to be the main rule of the service. Each namespace will have its own configuration
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73101
    /// </summary>
    public class DeleteGroupConfigurationV1 : AccelByte.Sdk.Core.Operation
    {
        public DeleteGroupConfigurationV1(
            string configurationCode,            
            string namespace_            
        )
        {
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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