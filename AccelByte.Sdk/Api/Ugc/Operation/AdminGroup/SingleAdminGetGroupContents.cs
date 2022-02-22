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
    /// SingleAdminGetGroupContents
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [READ].
    /// </summary>
    public class SingleAdminGetGroupContents : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminGetGroupContentsBuilder Builder = new SingleAdminGetGroupContentsBuilder();

        public class SingleAdminGetGroupContentsBuilder
        {
            
            
            public string? Limit { get; set; }
            
            public string? Offset { get; set; }
            
            internal SingleAdminGetGroupContentsBuilder() { }


            public SingleAdminGetGroupContentsBuilder SetLimit(string _limit)
            {
                Limit = _limit;
                return this;
            }

            public SingleAdminGetGroupContentsBuilder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }




            public SingleAdminGetGroupContents Build(
                string groupId,
                string namespace_
            )
            {
                return new SingleAdminGetGroupContents(this,
                    groupId,                    
                    namespace_                    
                );
            }
        }

        private SingleAdminGetGroupContents(SingleAdminGetGroupContentsBuilder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = builder.Limit;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            
            
            
            
        }
        #endregion

        public SingleAdminGetGroupContents(
            string groupId,            
            string namespace_,            
            string? limit,            
            string? offset            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = limit;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}/contents";

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