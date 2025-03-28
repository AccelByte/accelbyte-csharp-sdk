// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// FleetServers
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [READ]
    /// </summary>
    public class FleetServers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetServersBuilder Builder { get => new FleetServersBuilder(); }

        public class FleetServersBuilder
            : OperationBuilder<FleetServersBuilder>
        {

            public long? Count { get; set; }

            public long? Offset { get; set; }

            public string? Region { get; set; }

            public string? ServerId { get; set; }

            public string? SortBy { get; set; }

            public FleetServersSortDirection? SortDirection { get; set; }

            public FleetServersStatus? Status { get; set; }





            internal FleetServersBuilder() { }


            public FleetServersBuilder SetCount(long _count)
            {
                Count = _count;
                return this;
            }

            public FleetServersBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public FleetServersBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public FleetServersBuilder SetServerId(string _serverId)
            {
                ServerId = _serverId;
                return this;
            }

            public FleetServersBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public FleetServersBuilder SetSortDirection(FleetServersSortDirection _sortDirection)
            {
                SortDirection = _sortDirection;
                return this;
            }

            public FleetServersBuilder SetStatus(FleetServersStatus _status)
            {
                Status = _status;
                return this;
            }





            public FleetServers Build(
                string fleetID,
                string namespace_
            )
            {
                FleetServers op = new FleetServers(this,
                    fleetID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private FleetServers(FleetServersBuilder builder,
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;

            if (builder.Count != null) QueryParams["count"] = Convert.ToString(builder.Count)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.ServerId is not null) QueryParams["serverId"] = builder.ServerId;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.SortDirection is not null) QueryParams["sortDirection"] = builder.SortDirection.Value;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetServers(
            string fleetID,
            string namespace_,
            long? count,
            long? offset,
            string? region,
            string? serverId,
            string? sortBy,
            FleetServersSortDirection? sortDirection,
            FleetServersStatus? status
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;

            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region is not null) QueryParams["region"] = region;
            if (serverId is not null) QueryParams["serverId"] = serverId;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (sortDirection is not null) QueryParams["sortDirection"] = sortDirection.Value;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/servers";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiFleetServersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiFleetServersResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiFleetServersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetServersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class FleetServersSortDirection : StringEnum<FleetServersSortDirection>
    {
        public static readonly FleetServersSortDirection Asc
            = new FleetServersSortDirection("asc");

        public static readonly FleetServersSortDirection Desc
            = new FleetServersSortDirection("desc");


        public static implicit operator FleetServersSortDirection(string value)
        {
            return NewValue(value);
        }

        public FleetServersSortDirection(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class FleetServersStatus : StringEnum<FleetServersStatus>
    {
        public static readonly FleetServersStatus Claimed
            = new FleetServersStatus("claimed");

        public static readonly FleetServersStatus Claiming
            = new FleetServersStatus("claiming");

        public static readonly FleetServersStatus CrashBackoff
            = new FleetServersStatus("crash backoff");

        public static readonly FleetServersStatus Creating
            = new FleetServersStatus("creating");

        public static readonly FleetServersStatus Draining
            = new FleetServersStatus("draining");

        public static readonly FleetServersStatus Ready
            = new FleetServersStatus("ready");

        public static readonly FleetServersStatus Unresponsive
            = new FleetServersStatus("unresponsive");


        public static implicit operator FleetServersStatus(string value)
        {
            return NewValue(value);
        }

        public FleetServersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}