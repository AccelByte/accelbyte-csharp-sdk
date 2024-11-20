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
    /// bulkGetStatCycle_1
    ///
    /// Bulk get stat cycle.
    /// Other detail info:
    ///             *  Returns : list of stat cycles
    /// </summary>
    public class BulkGetStatCycle1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetStatCycle1Builder Builder { get => new BulkGetStatCycle1Builder(); }

        public class BulkGetStatCycle1Builder
            : OperationBuilder<BulkGetStatCycle1Builder>
        {





            internal BulkGetStatCycle1Builder() { }






            public BulkGetStatCycle1 Build(
                BulkStatCycleRequest body,
                string namespace_
            )
            {
                BulkGetStatCycle1 op = new BulkGetStatCycle1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private BulkGetStatCycle1(BulkGetStatCycle1Builder builder,
            BulkStatCycleRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetStatCycle1(
            string namespace_,
            Model.BulkStatCycleRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statCycles/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.BulkStatCycleResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.BulkStatCycleResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.BulkStatCycleResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkStatCycleResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}