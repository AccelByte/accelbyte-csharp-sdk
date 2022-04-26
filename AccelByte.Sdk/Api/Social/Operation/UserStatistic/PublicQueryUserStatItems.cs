// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicQueryUserStatItems
    ///
    /// Public list all statItems by pagination.
    /// Other detail info:
    ///               *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=2 (READ)
    ///               *  Returns : stat items
    /// </summary>
    public class PublicQueryUserStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserStatItemsBuilder Builder = new PublicQueryUserStatItemsBuilder();

        public class PublicQueryUserStatItemsBuilder
            : OperationBuilder<PublicQueryUserStatItemsBuilder>
        {
            
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? StatCodes { get; set; }
            
            public string? Tags { get; set; }
            
            internal PublicQueryUserStatItemsBuilder() { }


            public PublicQueryUserStatItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserStatItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryUserStatItemsBuilder SetStatCodes(string _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }

            public PublicQueryUserStatItemsBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicQueryUserStatItems Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserStatItems op = new PublicQueryUserStatItems(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicQueryUserStatItems(PublicQueryUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StatCodes != null) QueryParams["statCodes"] = builder.StatCodes;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserStatItems(
            string namespace_,            
            string userId,            
            int? limit,            
            int? offset,            
            string? statCodes,            
            string? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (statCodes != null) QueryParams["statCodes"] = statCodes;
            if (tags != null) QueryParams["tags"] = tags;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/statitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.UserStatItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserStatItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserStatItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}