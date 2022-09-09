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
    /// PublicSearchCreator
    ///
    /// Public user can access without token or if token specified, requires valid user token
    /// </summary>
    public class PublicSearchCreator : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSearchCreatorBuilder Builder = new PublicSearchCreatorBuilder();

        public class PublicSearchCreatorBuilder
            : OperationBuilder<PublicSearchCreatorBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Orderby { get; set; }

            public string? Sortby { get; set; }





            internal PublicSearchCreatorBuilder() { }


            public PublicSearchCreatorBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicSearchCreatorBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicSearchCreatorBuilder SetOrderby(string _orderby)
            {
                Orderby = _orderby;
                return this;
            }

            public PublicSearchCreatorBuilder SetSortby(string _sortby)
            {
                Sortby = _sortby;
                return this;
            }





            public PublicSearchCreator Build(
                string namespace_
            )
            {
                PublicSearchCreator op = new PublicSearchCreator(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicSearchCreator(PublicSearchCreatorBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Orderby is not null) QueryParams["orderby"] = builder.Orderby;
            if (builder.Sortby is not null) QueryParams["sortby"] = builder.Sortby;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSearchCreator(
            string namespace_,            
            long? limit,            
            long? offset,            
            string? orderby,            
            string? sortby            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderby is not null) QueryParams["orderby"] = orderby;
            if (sortby is not null) QueryParams["sortby"] = sortby;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsPaginatedCreatorOverviewResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedCreatorOverviewResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedCreatorOverviewResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}