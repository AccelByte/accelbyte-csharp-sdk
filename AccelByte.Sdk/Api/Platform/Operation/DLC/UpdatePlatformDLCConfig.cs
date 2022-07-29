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
    /// updatePlatformDLCConfig
    ///
    /// Update Platform DLC config. Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:DLC:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated Platform DLC config
    /// </summary>
    public class UpdatePlatformDLCConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePlatformDLCConfigBuilder Builder = new UpdatePlatformDLCConfigBuilder();

        public class UpdatePlatformDLCConfigBuilder
            : OperationBuilder<UpdatePlatformDLCConfigBuilder>
        {


            public Model.PlatformDLCConfigUpdate? Body { get; set; }




            internal UpdatePlatformDLCConfigBuilder() { }



            public UpdatePlatformDLCConfigBuilder SetBody(Model.PlatformDLCConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePlatformDLCConfig Build(
                string namespace_
            )
            {
                UpdatePlatformDLCConfig op = new UpdatePlatformDLCConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdatePlatformDLCConfig(UpdatePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePlatformDLCConfig(
            string namespace_,            
            Model.PlatformDLCConfigUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/dlc/config/platformMap";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PlatformDLCConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PlatformDLCConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PlatformDLCConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}