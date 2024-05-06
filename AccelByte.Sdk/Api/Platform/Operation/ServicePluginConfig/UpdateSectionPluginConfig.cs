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
    /// updateSectionPluginConfig
    ///
    /// Update section config. Other detail info:
    ///   * Returns : updated service plugin config
    /// </summary>
    public class UpdateSectionPluginConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSectionPluginConfigBuilder Builder { get => new UpdateSectionPluginConfigBuilder(); }

        public class UpdateSectionPluginConfigBuilder
            : OperationBuilder<UpdateSectionPluginConfigBuilder>
        {


            public Model.SectionPluginConfigUpdate? Body { get; set; }




            internal UpdateSectionPluginConfigBuilder() { }



            public UpdateSectionPluginConfigBuilder SetBody(Model.SectionPluginConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateSectionPluginConfig Build(
                string namespace_
            )
            {
                UpdateSectionPluginConfig op = new UpdateSectionPluginConfig(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateSectionPluginConfig(UpdateSectionPluginConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateSectionPluginConfig(
            string namespace_,
            Model.SectionPluginConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/section";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.SectionPluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.SectionPluginConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.SectionPluginConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SectionPluginConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}