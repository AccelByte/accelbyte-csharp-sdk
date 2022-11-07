// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getStadiaIAPConfig
    ///
    /// Get stadia iap config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=2 (READ)
    ///   *  Returns : stadia iap config
    /// </summary>
    public class GetStadiaIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStadiaIAPConfigBuilder Builder = new GetStadiaIAPConfigBuilder();

        public class GetStadiaIAPConfigBuilder
            : OperationBuilder<GetStadiaIAPConfigBuilder>
        {





            internal GetStadiaIAPConfigBuilder() { }






            public GetStadiaIAPConfig Build(
                string namespace_
            )
            {
                GetStadiaIAPConfig op = new GetStadiaIAPConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetStadiaIAPConfig(GetStadiaIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetStadiaIAPConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/stadia";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.StadiaIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StadiaIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StadiaIAPConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}