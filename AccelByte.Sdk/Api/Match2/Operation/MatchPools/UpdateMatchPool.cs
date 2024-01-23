// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// UpdateMatchPool
    ///
    /// Updates an existing matchmaking pool.
    /// 
    /// ticket_expiration_seconds and backfill_ticket_expiration_seconds will be set to 300 seconds (5 minutes) by default if not filled.
    /// 
    /// Match Function holds information about the name of the match logic server that matchmaking can refers to. By default we provide ("default" and "basic").
    /// Match Function will be used as reference value for Match Function Overrides if not set.
    /// In case Customer would like to use matchmaking service default match logic, then specify it in "match_function_overrides".
    /// This sample configuration will let matchmaking service will use "default" match logic for make matches, while validation will hit both "default" and "custom" match logics.
    /// e.g.
    /// {
    /// "match_function": "custom",
    /// "match_function_overrides": {
    /// "validation": []{"default","custom"},
    /// "make_matches": "default",
    /// }
    /// }
    /// </summary>
    public class UpdateMatchPool : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMatchPoolBuilder Builder { get => new UpdateMatchPoolBuilder(); }

        public class UpdateMatchPoolBuilder
            : OperationBuilder<UpdateMatchPoolBuilder>
        {





            internal UpdateMatchPoolBuilder() { }






            public UpdateMatchPool Build(
                ApiMatchPoolConfig body,
                string namespace_,
                string pool
            )
            {
                UpdateMatchPool op = new UpdateMatchPool(this,
                    body,
                    namespace_,
                    pool
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateMatchPool(UpdateMatchPoolBuilder builder,
            ApiMatchPoolConfig body,
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateMatchPool(
            string namespace_,
            string pool,
            Model.ApiMatchPoolConfig body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools/{pool}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiMatchPool? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiMatchPool>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiMatchPool>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchPool>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}