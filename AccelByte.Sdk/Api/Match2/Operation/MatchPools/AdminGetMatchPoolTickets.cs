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
    /// adminGetMatchPoolTickets
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:POOL:TICKETS [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Get tickets in queue for a specific match pool
    /// 
    /// Result: number of tickets and list of ticket detail in a match pool.
    /// </summary>
    public class AdminGetMatchPoolTickets : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMatchPoolTicketsBuilder Builder { get => new AdminGetMatchPoolTicketsBuilder(); }

        public class AdminGetMatchPoolTicketsBuilder
            : OperationBuilder<AdminGetMatchPoolTicketsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal AdminGetMatchPoolTicketsBuilder() { }


            public AdminGetMatchPoolTicketsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetMatchPoolTicketsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminGetMatchPoolTickets Build(
                string namespace_,
                string pool
            )
            {
                AdminGetMatchPoolTickets op = new AdminGetMatchPoolTickets(this,
                    namespace_,
                    pool
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetMatchPoolTickets(AdminGetMatchPoolTicketsBuilder builder,
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetMatchPoolTickets(
            string namespace_,
            string pool,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools/{pool}/tickets";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiListMatchPoolTicketsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiListMatchPoolTicketsResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiListMatchPoolTicketsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiListMatchPoolTicketsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}