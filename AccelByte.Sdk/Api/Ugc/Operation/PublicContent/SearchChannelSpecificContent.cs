// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// SearchChannelSpecificContent
    ///
    /// Requires valid user token.
    /// 
    /// For advance tag filtering supports & as AND operator and | as OR operator and parentheses () for priority. e.g:
    /// 
    /// `tags=red`
    /// 
    /// `tags=red&animal;`
    /// 
    /// `tags=red|animal`
    /// 
    /// `tags=red&animal;|wild`
    /// 
    /// `tags=red&(animal|wild)`
    /// 
    /// The precedence of logical operator is AND > OR, so if no parentheses, AND logical operator will be executed first.
    /// 
    /// Allowed character for operand: alphanumeric, underscore `_` and dash `-`
    /// 
    /// Allowed character for operator: `&` `|` `(` `)`
    /// 
    ///  Please note that value of tags query param should be URL encoded
    /// </summary>
    public class SearchChannelSpecificContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchChannelSpecificContentBuilder Builder { get => new SearchChannelSpecificContentBuilder(); }

        public class SearchChannelSpecificContentBuilder
            : OperationBuilder<SearchChannelSpecificContentBuilder>
        {

            public string? Creator { get; set; }

            public string? Isofficial { get; set; }

            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? Orderby { get; set; }

            public string? Sortby { get; set; }

            public string? Subtype { get; set; }

            public List<string>? Tags { get; set; }

            public string? Type { get; set; }

            public string? UserId { get; set; }





            internal SearchChannelSpecificContentBuilder() { }


            public SearchChannelSpecificContentBuilder SetCreator(string _creator)
            {
                Creator = _creator;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetIsofficial(string _isofficial)
            {
                Isofficial = _isofficial;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetOrderby(string _orderby)
            {
                Orderby = _orderby;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetSortby(string _sortby)
            {
                Sortby = _sortby;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetSubtype(string _subtype)
            {
                Subtype = _subtype;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public SearchChannelSpecificContentBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public SearchChannelSpecificContent Build(
                string channelId,
                string namespace_
            )
            {
                SearchChannelSpecificContent op = new SearchChannelSpecificContent(this,
                    channelId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SearchChannelSpecificContent(SearchChannelSpecificContentBuilder builder,
            string channelId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;

            if (builder.Creator is not null) QueryParams["creator"] = builder.Creator;
            if (builder.Isofficial is not null) QueryParams["isofficial"] = builder.Isofficial;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Orderby is not null) QueryParams["orderby"] = builder.Orderby;
            if (builder.Sortby is not null) QueryParams["sortby"] = builder.Sortby;
            if (builder.Subtype is not null) QueryParams["subtype"] = builder.Subtype;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.Type is not null) QueryParams["type"] = builder.Type;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SearchChannelSpecificContent(
            string channelId,
            string namespace_,
            string? creator,
            string? isofficial,
            long? limit,
            string? name,
            long? offset,
            string? orderby,
            string? sortby,
            string? subtype,
            List<string>? tags,
            string? type,
            string? userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;

            if (creator is not null) QueryParams["creator"] = creator;
            if (isofficial is not null) QueryParams["isofficial"] = isofficial;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderby is not null) QueryParams["orderby"] = orderby;
            if (sortby is not null) QueryParams["sortby"] = sortby;
            if (subtype is not null) QueryParams["subtype"] = subtype;
            if (tags is not null) QueryParams["tags"] = tags;
            if (type is not null) QueryParams["type"] = type;
            if (userId is not null) QueryParams["userId"] = userId;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json", "application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

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