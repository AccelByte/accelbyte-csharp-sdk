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
    /// updateServicePluginConfig
    ///
    /// Update catalog config. Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:CONFIG:SERVICEPLUGIN, action=4 (UPDATE)
    ///   *  Returns : updated service plugin config
    /// </summary>
    public class UpdateServicePluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateServicePluginConfigBuilder Builder { get => new UpdateServicePluginConfigBuilder(); }

        public class UpdateServicePluginConfigBuilder
            : OperationBuilder<UpdateServicePluginConfigBuilder>
        {


            public Model.ServicePluginConfigUpdate? Body { get; set; }




            internal UpdateServicePluginConfigBuilder() { }



            public UpdateServicePluginConfigBuilder SetBody(Model.ServicePluginConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateServicePluginConfig Build(
                string namespace_
            )
            {
                UpdateServicePluginConfig op = new UpdateServicePluginConfig(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateServicePluginConfig(UpdateServicePluginConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateServicePluginConfig(
            string namespace_,
            Model.ServicePluginConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/configs/servicePlugin";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ServicePluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ServicePluginConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ServicePluginConfigInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}