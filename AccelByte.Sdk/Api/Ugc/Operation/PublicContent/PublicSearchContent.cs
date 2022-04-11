// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// PublicSearchContent
    ///
    /// Public user can access without token or if token specified, requires valid user token
    /// </summary>
    public class PublicSearchContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSearchContentBuilder Builder = new PublicSearchContentBuilder();

        public class PublicSearchContentBuilder
        {
            
            public string? Creator { get; set; }
            
            public string? Isofficial { get; set; }
            
            public long? Limit { get; set; }
            
            public string? Name { get; set; }
            
            public long? Offset { get; set; }
            
            public string? Orderby { get; set; }
            
            public string? Sortby { get; set; }
            
            public string? Subtype { get; set; }
            
            public string? Tags { get; set; }
            
            public string? Type { get; set; }
            
            public string? UserId { get; set; }
            
            internal PublicSearchContentBuilder() { }


            public PublicSearchContentBuilder SetCreator(string _creator)
            {
                Creator = _creator;
                return this;
            }

            public PublicSearchContentBuilder SetIsofficial(string _isofficial)
            {
                Isofficial = _isofficial;
                return this;
            }

            public PublicSearchContentBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicSearchContentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public PublicSearchContentBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicSearchContentBuilder SetOrderby(string _orderby)
            {
                Orderby = _orderby;
                return this;
            }

            public PublicSearchContentBuilder SetSortby(string _sortby)
            {
                Sortby = _sortby;
                return this;
            }

            public PublicSearchContentBuilder SetSubtype(string _subtype)
            {
                Subtype = _subtype;
                return this;
            }

            public PublicSearchContentBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }

            public PublicSearchContentBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public PublicSearchContentBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }




            public PublicSearchContent Build(
                string namespace_
            )
            {
                return new PublicSearchContent(this,
                    namespace_                    
                );
            }
        }

        private PublicSearchContent(PublicSearchContentBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Creator != null) QueryParams["creator"] = builder.Creator;
            if (builder.Isofficial != null) QueryParams["isofficial"] = builder.Isofficial;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name != null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Orderby != null) QueryParams["orderby"] = builder.Orderby;
            if (builder.Sortby != null) QueryParams["sortby"] = builder.Sortby;
            if (builder.Subtype != null) QueryParams["subtype"] = builder.Subtype;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            if (builder.Type != null) QueryParams["type"] = builder.Type;
            if (builder.UserId != null) QueryParams["userId"] = builder.UserId;
            
            
            
            
        }
        #endregion

        public PublicSearchContent(
            string namespace_,            
            string? creator,            
            string? isofficial,            
            long? limit,            
            string? name,            
            long? offset,            
            string? orderby,            
            string? sortby,            
            string? subtype,            
            string? tags,            
            string? type,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (creator != null) QueryParams["creator"] = creator;
            if (isofficial != null) QueryParams["isofficial"] = isofficial;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name != null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderby != null) QueryParams["orderby"] = orderby;
            if (sortby != null) QueryParams["sortby"] = sortby;
            if (subtype != null) QueryParams["subtype"] = subtype;
            if (tags != null) QueryParams["tags"] = tags;
            if (type != null) QueryParams["type"] = type;
            if (userId != null) QueryParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPaginatedContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}