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
    /// getStatCycles_1
    ///
    /// List stat cycles by pagination.
    /// Other detail info:
    /// 
    ///   *  Required permission : resource="NAMESPACE:{namespace}:STAT", action=2 (READ)
    ///   *  Returns : stat cycles
    /// </summary>
    public class GetStatCycles1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatCycles1Builder Builder { get => new GetStatCycles1Builder(); }

        public class GetStatCycles1Builder
            : OperationBuilder<GetStatCycles1Builder>
        {

            public GetStatCycles1CycleType? CycleType { get; set; }

            public int? Limit { get; set; }

            public string? Name { get; set; }

            public int? Offset { get; set; }

            public GetStatCycles1Status? Status { get; set; }





            internal GetStatCycles1Builder() { }


            public GetStatCycles1Builder SetCycleType(GetStatCycles1CycleType _cycleType)
            {
                CycleType = _cycleType;
                return this;
            }

            public GetStatCycles1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetStatCycles1Builder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public GetStatCycles1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetStatCycles1Builder SetStatus(GetStatCycles1Status _status)
            {
                Status = _status;
                return this;
            }





            public GetStatCycles1 Build(
                string namespace_
            )
            {
                GetStatCycles1 op = new GetStatCycles1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetStatCycles1(GetStatCycles1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.CycleType is not null) QueryParams["cycleType"] = builder.CycleType.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetStatCycles1(
            string namespace_,
            GetStatCycles1CycleType? cycleType,
            int? limit,
            string? name,
            int? offset,
            GetStatCycles1Status? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (cycleType is not null) QueryParams["cycleType"] = cycleType.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statCycles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.StatCyclePagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatCyclePagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatCyclePagingSlicedResult>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetStatCycles1CycleType : StringEnum<GetStatCycles1CycleType>
    {
        public static readonly GetStatCycles1CycleType ANNUALLY
            = new GetStatCycles1CycleType("ANNUALLY");

        public static readonly GetStatCycles1CycleType DAILY
            = new GetStatCycles1CycleType("DAILY");

        public static readonly GetStatCycles1CycleType MONTHLY
            = new GetStatCycles1CycleType("MONTHLY");

        public static readonly GetStatCycles1CycleType SEASONAL
            = new GetStatCycles1CycleType("SEASONAL");

        public static readonly GetStatCycles1CycleType WEEKLY
            = new GetStatCycles1CycleType("WEEKLY");


        public static implicit operator GetStatCycles1CycleType(string value)
        {
            return NewValue(value);
        }

        public GetStatCycles1CycleType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class GetStatCycles1Status : StringEnum<GetStatCycles1Status>
    {
        public static readonly GetStatCycles1Status ACTIVE
            = new GetStatCycles1Status("ACTIVE");

        public static readonly GetStatCycles1Status INIT
            = new GetStatCycles1Status("INIT");

        public static readonly GetStatCycles1Status STOPPED
            = new GetStatCycles1Status("STOPPED");


        public static implicit operator GetStatCycles1Status(string value)
        {
            return NewValue(value);
        }

        public GetStatCycles1Status(string enumValue)
            : base(enumValue)
        {

        }
    }

}