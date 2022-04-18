// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    /// </summary>
    public class ListImages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListImagesBuilder Builder = new ListImagesBuilder();

        public class ListImagesBuilder
            : OperationBuilder<ListImagesBuilder>
        {
            
            public long? Count { get; set; }
            
            public long? Offset { get; set; }
            
            public string? Q { get; set; }
            
            public string? SortBy { get; set; }
            
            public string? SortDirection { get; set; }
            
            internal ListImagesBuilder() { }


            public ListImagesBuilder SetCount(long _count)
            {
                Count = _count;
                return this;
            }

            public ListImagesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListImagesBuilder SetQ(string _q)
            {
                Q = _q;
                return this;
            }

            public ListImagesBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public ListImagesBuilder SetSortDirection(string _sortDirection)
            {
                SortDirection = _sortDirection;
                return this;
            }




            public ListImages Build(
                string namespace_
            )
            {
                ListImages op = new ListImages(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListImages(ListImagesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Count != null) QueryParams["count"] = Convert.ToString(builder.Count)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Q != null) QueryParams["q"] = builder.Q;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.SortDirection != null) QueryParams["sortDirection"] = builder.SortDirection;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListImages(
            string namespace_,            
            long? count,            
            long? offset,            
            string? q,            
            string? sortBy,            
            string? sortDirection            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (q != null) QueryParams["q"] = q;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (sortDirection != null) QueryParams["sortDirection"] = sortDirection;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsListImageResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImageResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImageResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}