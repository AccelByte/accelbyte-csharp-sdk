// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// DevelopmentServerConfigurationGet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [READ]
    /// </summary>
    public class DevelopmentServerConfigurationGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DevelopmentServerConfigurationGetBuilder Builder { get => new DevelopmentServerConfigurationGetBuilder(); }

        public class DevelopmentServerConfigurationGetBuilder
            : OperationBuilder<DevelopmentServerConfigurationGetBuilder>
        {





            internal DevelopmentServerConfigurationGetBuilder() { }






            public DevelopmentServerConfigurationGet Build(
                string developmentServerConfigID,
                string namespace_
            )
            {
                DevelopmentServerConfigurationGet op = new DevelopmentServerConfigurationGet(this,
                    developmentServerConfigID,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DevelopmentServerConfigurationGet(DevelopmentServerConfigurationGetBuilder builder,
            string developmentServerConfigID,
            string namespace_
        )
        {
            PathParams["developmentServerConfigID"] = developmentServerConfigID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DevelopmentServerConfigurationGet(
            string developmentServerConfigID,            
            string namespace_            
        )
        {
            PathParams["developmentServerConfigID"] = developmentServerConfigID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/development/server-configurations/{developmentServerConfigID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApiDevelopmentServerConfigurationGetResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiDevelopmentServerConfigurationGetResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiDevelopmentServerConfigurationGetResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiDevelopmentServerConfigurationGetResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}