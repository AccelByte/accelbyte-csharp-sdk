// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ListImages
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint lists all of dedicated servers images.
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class ListImages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListImagesBuilder Builder { get => new ListImagesBuilder(); }

        public class ListImagesBuilder
            : OperationBuilder<ListImagesBuilder>
        {

            public string? Q { get; set; }

            public ListImagesSortBy? SortBy { get; set; }

            public ListImagesSortDirection? SortDirection { get; set; }





            internal ListImagesBuilder() { }


            public ListImagesBuilder SetQ(string _q)
            {
                Q = _q;
                return this;
            }

            public ListImagesBuilder SetSortBy(ListImagesSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public ListImagesBuilder SetSortDirection(ListImagesSortDirection _sortDirection)
            {
                SortDirection = _sortDirection;
                return this;
            }





            public ListImages Build(
                string namespace_,
                long count,
                long offset
            )
            {
                ListImages op = new ListImages(this,
                    namespace_,
                    count,
                    offset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private ListImages(ListImagesBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Q is not null) QueryParams["q"] = builder.Q;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.SortDirection is not null) QueryParams["sortDirection"] = builder.SortDirection.Value;
            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListImages(
            string namespace_,
            string? q,
            ListImagesSortBy? sortBy,
            ListImagesSortDirection? sortDirection,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (q is not null) QueryParams["q"] = q;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (sortDirection is not null) QueryParams["sortDirection"] = sortDirection.Value;
            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListImageResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsListImageResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsListImageResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImageResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class ListImagesSortBy : StringEnum<ListImagesSortBy>
    {
        public static readonly ListImagesSortBy CreatedAt
            = new ListImagesSortBy("createdAt");

        public static readonly ListImagesSortBy UpdatedAt
            = new ListImagesSortBy("updatedAt");

        public static readonly ListImagesSortBy Version
            = new ListImagesSortBy("version");


        public static implicit operator ListImagesSortBy(string value)
        {
            return NewValue(value);
        }

        public ListImagesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ListImagesSortDirection : StringEnum<ListImagesSortDirection>
    {
        public static readonly ListImagesSortDirection Asc
            = new ListImagesSortDirection("asc");

        public static readonly ListImagesSortDirection Desc
            = new ListImagesSortDirection("desc");


        public static implicit operator ListImagesSortDirection(string value)
        {
            return NewValue(value);
        }

        public ListImagesSortDirection(string enumValue)
            : base(enumValue)
        {

        }
    }

}