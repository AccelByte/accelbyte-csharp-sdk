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
    /// deleteStatCycle
    ///
    /// Deletes stat cycle.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=8 (DELETE)
    /// </summary>
    public class DeleteStatCycle : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteStatCycleBuilder Builder { get => new DeleteStatCycleBuilder(); }

        public class DeleteStatCycleBuilder
            : OperationBuilder<DeleteStatCycleBuilder>
        {





            internal DeleteStatCycleBuilder() { }






            public DeleteStatCycle Build(
                string cycleId,
                string namespace_
            )
            {
                DeleteStatCycle op = new DeleteStatCycle(this,
                    cycleId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private DeleteStatCycle(DeleteStatCycleBuilder builder,
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteStatCycle(
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}