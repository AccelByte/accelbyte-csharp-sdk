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
    /// getGlobalStatItems
    ///
    /// List global statItems by pagination.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    ///         *  Returns : stat items
    /// ul
    /// </summary>
    public class GetGlobalStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGlobalStatItemsBuilder Builder = new GetGlobalStatItemsBuilder();

        public class GetGlobalStatItemsBuilder
        {
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            internal GetGlobalStatItemsBuilder() { }


            public GetGlobalStatItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGlobalStatItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetGlobalStatItems Build(
                string namespace_
            )
            {
                return new GetGlobalStatItems(this,
                    namespace_                    
                );
            }
        }

        private GetGlobalStatItems(GetGlobalStatItemsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public GetGlobalStatItems(
            string namespace_,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/globalstatitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.GlobalStatItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}