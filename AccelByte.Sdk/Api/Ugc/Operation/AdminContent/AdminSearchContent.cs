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
    /// AdminSearchContent
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:*:CONTENT [CREATE]
    /// </summary>
    public class AdminSearchContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSearchContentBuilder Builder = new AdminSearchContentBuilder();

        public class AdminSearchContentBuilder
        {
            
            public string? Creator { get; set; }
            
            public string? Isofficial { get; set; }
            
            public string? Limit { get; set; }
            
            public string? Name { get; set; }
            
            public string? Offset { get; set; }
            
            public string? Orderby { get; set; }
            
            public string? Sortby { get; set; }
            
            public string? Subtype { get; set; }
            
            public string? Tags { get; set; }
            
            public string? Type { get; set; }
            
            public string? UserId { get; set; }
            
            internal AdminSearchContentBuilder() { }


            public AdminSearchContentBuilder SetCreator(string _creator)
            {
                Creator = _creator;
                return this;
            }

            public AdminSearchContentBuilder SetIsofficial(string _isofficial)
            {
                Isofficial = _isofficial;
                return this;
            }

            public AdminSearchContentBuilder SetLimit(string _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminSearchContentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public AdminSearchContentBuilder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminSearchContentBuilder SetOrderby(string _orderby)
            {
                Orderby = _orderby;
                return this;
            }

            public AdminSearchContentBuilder SetSortby(string _sortby)
            {
                Sortby = _sortby;
                return this;
            }

            public AdminSearchContentBuilder SetSubtype(string _subtype)
            {
                Subtype = _subtype;
                return this;
            }

            public AdminSearchContentBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }

            public AdminSearchContentBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public AdminSearchContentBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }




            public AdminSearchContent Build(
                string namespace_
            )
            {
                return new AdminSearchContent(this,
                    namespace_                    
                );
            }
        }

        private AdminSearchContent(AdminSearchContentBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Creator != null) QueryParams["creator"] = builder.Creator;
            if (builder.Isofficial != null) QueryParams["isofficial"] = builder.Isofficial;
            if (builder.Limit != null) QueryParams["limit"] = builder.Limit;
            if (builder.Name != null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            if (builder.Orderby != null) QueryParams["orderby"] = builder.Orderby;
            if (builder.Sortby != null) QueryParams["sortby"] = builder.Sortby;
            if (builder.Subtype != null) QueryParams["subtype"] = builder.Subtype;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            if (builder.Type != null) QueryParams["type"] = builder.Type;
            if (builder.UserId != null) QueryParams["userId"] = builder.UserId;
            
            
            
            
        }
        #endregion

        public AdminSearchContent(
            string namespace_,            
            string? creator,            
            string? isofficial,            
            string? limit,            
            string? name,            
            string? offset,            
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
            if (limit != null) QueryParams["limit"] = limit;
            if (name != null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = offset;
            if (orderby != null) QueryParams["orderby"] = orderby;
            if (sortby != null) QueryParams["sortby"] = sortby;
            if (subtype != null) QueryParams["subtype"] = subtype;
            if (tags != null) QueryParams["tags"] = tags;
            if (type != null) QueryParams["type"] = type;
            if (userId != null) QueryParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

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