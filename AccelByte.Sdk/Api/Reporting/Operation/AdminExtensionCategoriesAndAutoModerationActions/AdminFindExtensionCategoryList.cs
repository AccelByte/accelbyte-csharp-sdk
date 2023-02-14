// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// adminFindExtensionCategoryList
    ///
    /// Required permission: ADMIN:REPORTINGCONFIG [READ]
    /// Get a list of extension category data with the specified name
    /// </summary>
    public class AdminFindExtensionCategoryList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminFindExtensionCategoryListBuilder Builder { get => new AdminFindExtensionCategoryListBuilder(); }

        public class AdminFindExtensionCategoryListBuilder
            : OperationBuilder<AdminFindExtensionCategoryListBuilder>
        {

            public AdminFindExtensionCategoryListOrder? Order { get; set; }

            public AdminFindExtensionCategoryListSortBy? SortBy { get; set; }





            internal AdminFindExtensionCategoryListBuilder() { }


            public AdminFindExtensionCategoryListBuilder SetOrder(AdminFindExtensionCategoryListOrder _order)
            {
                Order = _order;
                return this;
            }

            public AdminFindExtensionCategoryListBuilder SetSortBy(AdminFindExtensionCategoryListSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminFindExtensionCategoryList Build(
            )
            {
                AdminFindExtensionCategoryList op = new AdminFindExtensionCategoryList(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminFindExtensionCategoryList(AdminFindExtensionCategoryListBuilder builder
        )
        {

            if (builder.Order is not null) QueryParams["order"] = builder.Order.Value;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminFindExtensionCategoryList(
            AdminFindExtensionCategoryListOrder? order,
            AdminFindExtensionCategoryListSortBy? sortBy
        )
        {

            if (order is not null) QueryParams["order"] = order.Value;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/extensionCategories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiExtensionCategoryListApiResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiExtensionCategoryListApiResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiExtensionCategoryListApiResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminFindExtensionCategoryListOrder : StringEnum<AdminFindExtensionCategoryListOrder>
    {
        public static readonly AdminFindExtensionCategoryListOrder Asc
            = new AdminFindExtensionCategoryListOrder("asc");

        public static readonly AdminFindExtensionCategoryListOrder Ascending
            = new AdminFindExtensionCategoryListOrder("ascending");

        public static readonly AdminFindExtensionCategoryListOrder Desc
            = new AdminFindExtensionCategoryListOrder("desc");

        public static readonly AdminFindExtensionCategoryListOrder Descending
            = new AdminFindExtensionCategoryListOrder("descending");


        public static implicit operator AdminFindExtensionCategoryListOrder(string value)
        {
            return NewValue(value);
        }

        public AdminFindExtensionCategoryListOrder(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AdminFindExtensionCategoryListSortBy : StringEnum<AdminFindExtensionCategoryListSortBy>
    {
        public static readonly AdminFindExtensionCategoryListSortBy ExtensionCategory
            = new AdminFindExtensionCategoryListSortBy("extensionCategory");

        public static readonly AdminFindExtensionCategoryListSortBy ExtensionCategoryName
            = new AdminFindExtensionCategoryListSortBy("extensionCategoryName");


        public static implicit operator AdminFindExtensionCategoryListSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminFindExtensionCategoryListSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}