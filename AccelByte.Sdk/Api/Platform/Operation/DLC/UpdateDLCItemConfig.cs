// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateDLCItemConfig
    ///
    /// Update DLC item config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:DLC:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated DLC item config
    /// </summary>
    public class UpdateDLCItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateDLCItemConfigBuilder Builder = new UpdateDLCItemConfigBuilder();

        public class UpdateDLCItemConfigBuilder
            : OperationBuilder<UpdateDLCItemConfigBuilder>
        {
            
            public Model.DLCItemConfigUpdate? Body { get; set; }
            
            internal UpdateDLCItemConfigBuilder() { }



            public UpdateDLCItemConfigBuilder SetBody(Model.DLCItemConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateDLCItemConfig Build(
                string namespace_
            )
            {
                UpdateDLCItemConfig op = new UpdateDLCItemConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateDLCItemConfig(UpdateDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateDLCItemConfig(
            string namespace_,            
            Model.DLCItemConfigUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/dlc/config/item";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.DLCItemConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.DLCItemConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DLCItemConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}