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
    /// getGroupConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to get existing configuration. This Configuration is used to be the main rule of the service. Each namespace will have its own configuration
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73101
    /// </summary>
    public class GetGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupConfigurationAdminV1Builder Builder = new GetGroupConfigurationAdminV1Builder();

        public class GetGroupConfigurationAdminV1Builder
        {
            
            
            internal GetGroupConfigurationAdminV1Builder() { }





            public GetGroupConfigurationAdminV1 Build(
                string configurationCode,
                string namespace_
            )
            {
                return new GetGroupConfigurationAdminV1(this,
                    configurationCode,                    
                    namespace_                    
                );
            }
        }

        private GetGroupConfigurationAdminV1(GetGroupConfigurationAdminV1Builder builder,
            string configurationCode,
            string namespace_
        )
        {
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public GetGroupConfigurationAdminV1(
            string configurationCode,            
            string namespace_            
        )
        {
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupConfigurationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupConfigurationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}