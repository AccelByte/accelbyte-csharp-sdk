// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// updateStatCycle
    ///
    /// Update stat cycle.
    /// Other detail info:
    ///         *  Returns : updated stat cycle
    /// </summary>
    public class UpdateStatCycle : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateStatCycleBuilder Builder { get => new UpdateStatCycleBuilder(); }

        public class UpdateStatCycleBuilder
            : OperationBuilder<UpdateStatCycleBuilder>
        {


            public Model.StatCycleUpdate? Body { get; set; }




            internal UpdateStatCycleBuilder() { }



            public UpdateStatCycleBuilder SetBody(Model.StatCycleUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateStatCycle Build(
                string cycleId,
                string namespace_
            )
            {
                UpdateStatCycle op = new UpdateStatCycle(this,
                    cycleId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateStatCycle(UpdateStatCycleBuilder builder,
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateStatCycle(
            string cycleId,
            string namespace_,
            Model.StatCycleUpdate body
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.StatCycleInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}