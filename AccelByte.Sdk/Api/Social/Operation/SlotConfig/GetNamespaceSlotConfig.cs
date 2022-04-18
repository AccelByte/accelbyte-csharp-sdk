// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getNamespaceSlotConfig
    ///
    /// Get slot configuration for a given namespace. In case slot configuration is not set, the default will be returned.
    /// Other detail info:
    /// 
    ///   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:SLOTCONFIG", action=2 (READ)
    ///   *  Returns : namespace slot config info
    /// </summary>
    public class GetNamespaceSlotConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNamespaceSlotConfigBuilder Builder = new GetNamespaceSlotConfigBuilder();

        public class GetNamespaceSlotConfigBuilder
            : OperationBuilder<GetNamespaceSlotConfigBuilder>
        {
            
            internal GetNamespaceSlotConfigBuilder() { }





            public GetNamespaceSlotConfig Build(
                string namespace_
            )
            {
                GetNamespaceSlotConfig op = new GetNamespaceSlotConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetNamespaceSlotConfig(GetNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetNamespaceSlotConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.NamespaceSlotConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NamespaceSlotConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespaceSlotConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}