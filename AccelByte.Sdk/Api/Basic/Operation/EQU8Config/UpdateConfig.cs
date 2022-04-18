// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// updateConfig
    ///
    /// Update equ8 config, create if not exists.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:EQU8CONFIG" , action=4 (UPDATE)
    /// </summary>
    public class UpdateConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateConfigBuilder Builder = new UpdateConfigBuilder();

        public class UpdateConfigBuilder
            : OperationBuilder<UpdateConfigBuilder>
        {
            
            public Model.ADTOForUpdateEqu8ConfigAPICall? Body { get; set; }
            
            internal UpdateConfigBuilder() { }



            public UpdateConfigBuilder SetBody(Model.ADTOForUpdateEqu8ConfigAPICall _body)
            {
                Body = _body;
                return this;
            }



            public UpdateConfig Build(
                string namespace_
            )
            {
                UpdateConfig op = new UpdateConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateConfig(UpdateConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateConfig(
            string namespace_,            
            Model.ADTOForUpdateEqu8ConfigAPICall body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/equ8/config";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.Equ8Config? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Equ8Config>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Equ8Config>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}