// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminListInventoryConfigurations
    ///
    /// 
    /// Listing all inventory configurations in a namespace.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:CONFIGURATION [READ]
    /// </summary>
    public class AdminListInventoryConfigurations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListInventoryConfigurationsBuilder Builder { get => new AdminListInventoryConfigurationsBuilder(); }

        public class AdminListInventoryConfigurationsBuilder
            : OperationBuilder<AdminListInventoryConfigurationsBuilder>
        {

            public string? Code { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListInventoryConfigurationsSortBy? SortBy { get; set; }





            internal AdminListInventoryConfigurationsBuilder() { }


            public AdminListInventoryConfigurationsBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public AdminListInventoryConfigurationsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListInventoryConfigurationsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListInventoryConfigurationsBuilder SetSortBy(AdminListInventoryConfigurationsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminListInventoryConfigurations Build(
                string namespace_
            )
            {
                AdminListInventoryConfigurations op = new AdminListInventoryConfigurations(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListInventoryConfigurations(AdminListInventoryConfigurationsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListInventoryConfigurations(
            string namespace_,
            string? code,
            long? limit,
            long? offset,
            AdminListInventoryConfigurationsSortBy? sortBy
        )
        {
            PathParams["namespace"] = namespace_;

            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsListInventoryConfigurationsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsListInventoryConfigurationsResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsListInventoryConfigurationsResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListInventoryConfigurationsResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminListInventoryConfigurationsSortBy : StringEnum<AdminListInventoryConfigurationsSortBy>
    {
        public static readonly AdminListInventoryConfigurationsSortBy Code
            = new AdminListInventoryConfigurationsSortBy("code");

        public static readonly AdminListInventoryConfigurationsSortBy Codeasc
            = new AdminListInventoryConfigurationsSortBy("code:asc");

        public static readonly AdminListInventoryConfigurationsSortBy Codedesc
            = new AdminListInventoryConfigurationsSortBy("code:desc");

        public static readonly AdminListInventoryConfigurationsSortBy CreatedAt
            = new AdminListInventoryConfigurationsSortBy("createdAt");

        public static readonly AdminListInventoryConfigurationsSortBy CreatedAtasc
            = new AdminListInventoryConfigurationsSortBy("createdAt:asc");

        public static readonly AdminListInventoryConfigurationsSortBy CreatedAtdesc
            = new AdminListInventoryConfigurationsSortBy("createdAt:desc");

        public static readonly AdminListInventoryConfigurationsSortBy UpdatedAt
            = new AdminListInventoryConfigurationsSortBy("updatedAt");

        public static readonly AdminListInventoryConfigurationsSortBy UpdatedAtasc
            = new AdminListInventoryConfigurationsSortBy("updatedAt:asc");

        public static readonly AdminListInventoryConfigurationsSortBy UpdatedAtdesc
            = new AdminListInventoryConfigurationsSortBy("updatedAt:desc");


        public static implicit operator AdminListInventoryConfigurationsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListInventoryConfigurationsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}