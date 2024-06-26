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
    /// AdminListInventories
    ///
    /// 
    /// Listing all inventories in a namespace.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY [READ]
    /// </summary>
    public class AdminListInventories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListInventoriesBuilder Builder { get => new AdminListInventoriesBuilder(); }

        public class AdminListInventoriesBuilder
            : OperationBuilder<AdminListInventoriesBuilder>
        {

            public string? InventoryConfigurationCode { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListInventoriesSortBy? SortBy { get; set; }

            public string? UserId { get; set; }





            internal AdminListInventoriesBuilder() { }


            public AdminListInventoriesBuilder SetInventoryConfigurationCode(string _inventoryConfigurationCode)
            {
                InventoryConfigurationCode = _inventoryConfigurationCode;
                return this;
            }

            public AdminListInventoriesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListInventoriesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListInventoriesBuilder SetSortBy(AdminListInventoriesSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListInventoriesBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminListInventories Build(
                string namespace_
            )
            {
                AdminListInventories op = new AdminListInventories(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListInventories(AdminListInventoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.InventoryConfigurationCode is not null) QueryParams["inventoryConfigurationCode"] = builder.InventoryConfigurationCode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListInventories(
            string namespace_,
            string? inventoryConfigurationCode,
            long? limit,
            long? offset,
            AdminListInventoriesSortBy? sortBy,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (inventoryConfigurationCode is not null) QueryParams["inventoryConfigurationCode"] = inventoryConfigurationCode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsListInventoryResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsListInventoryResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsListInventoryResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListInventoryResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminListInventoriesSortBy : StringEnum<AdminListInventoriesSortBy>
    {
        public static readonly AdminListInventoriesSortBy CreatedAt
            = new AdminListInventoriesSortBy("createdAt");

        public static readonly AdminListInventoriesSortBy CreatedAtasc
            = new AdminListInventoriesSortBy("createdAt:asc");

        public static readonly AdminListInventoriesSortBy CreatedAtdesc
            = new AdminListInventoriesSortBy("createdAt:desc");

        public static readonly AdminListInventoriesSortBy InventoryConfigurationCode
            = new AdminListInventoriesSortBy("inventoryConfigurationCode");

        public static readonly AdminListInventoriesSortBy InventoryConfigurationCodeasc
            = new AdminListInventoriesSortBy("inventoryConfigurationCode:asc");

        public static readonly AdminListInventoriesSortBy InventoryConfigurationCodedesc
            = new AdminListInventoriesSortBy("inventoryConfigurationCode:desc");

        public static readonly AdminListInventoriesSortBy UpdatedAt
            = new AdminListInventoriesSortBy("updatedAt");

        public static readonly AdminListInventoriesSortBy UpdatedAtasc
            = new AdminListInventoriesSortBy("updatedAt:asc");

        public static readonly AdminListInventoriesSortBy UpdatedAtdesc
            = new AdminListInventoriesSortBy("updatedAt:desc");


        public static implicit operator AdminListInventoriesSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListInventoriesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}