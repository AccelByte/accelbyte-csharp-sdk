// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminProfanityQuery
    ///
    /// Query all profanity words.
    /// </summary>
    public class AdminProfanityQuery : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminProfanityQueryBuilder Builder { get => new AdminProfanityQueryBuilder(); }

        public class AdminProfanityQueryBuilder
            : OperationBuilder<AdminProfanityQueryBuilder>
        {

            public string? FilterMask { get; set; }

            public bool? IncludeChildren { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? ParentId { get; set; }

            public string? StartWith { get; set; }

            public string? WordType { get; set; }





            internal AdminProfanityQueryBuilder() { }


            public AdminProfanityQueryBuilder SetFilterMask(string _filterMask)
            {
                FilterMask = _filterMask;
                return this;
            }

            public AdminProfanityQueryBuilder SetIncludeChildren(bool _includeChildren)
            {
                IncludeChildren = _includeChildren;
                return this;
            }

            public AdminProfanityQueryBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminProfanityQueryBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminProfanityQueryBuilder SetParentId(string _parentId)
            {
                ParentId = _parentId;
                return this;
            }

            public AdminProfanityQueryBuilder SetStartWith(string _startWith)
            {
                StartWith = _startWith;
                return this;
            }

            public AdminProfanityQueryBuilder SetWordType(string _wordType)
            {
                WordType = _wordType;
                return this;
            }





            public AdminProfanityQuery Build(
                string namespace_
            )
            {
                AdminProfanityQuery op = new AdminProfanityQuery(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminProfanityQuery(AdminProfanityQueryBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.FilterMask is not null) QueryParams["filterMask"] = builder.FilterMask;
            if (builder.IncludeChildren != null) QueryParams["includeChildren"] = Convert.ToString(builder.IncludeChildren)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ParentId is not null) QueryParams["parentId"] = builder.ParentId;
            if (builder.StartWith is not null) QueryParams["startWith"] = builder.StartWith;
            if (builder.WordType is not null) QueryParams["wordType"] = builder.WordType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminProfanityQuery(
            string namespace_,            
            string? filterMask,            
            bool? includeChildren,            
            long? limit,            
            long? offset,            
            string? parentId,            
            string? startWith,            
            string? wordType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (filterMask is not null) QueryParams["filterMask"] = filterMask;
            if (includeChildren != null) QueryParams["includeChildren"] = Convert.ToString(includeChildren)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (parentId is not null) QueryParams["parentId"] = parentId;
            if (startWith is not null) QueryParams["startWith"] = startWith;
            if (wordType is not null) QueryParams["wordType"] = wordType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/profanity/namespaces/{namespace}/dictionary";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsDictionaryQueryResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsDictionaryQueryResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsDictionaryQueryResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDictionaryQueryResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}