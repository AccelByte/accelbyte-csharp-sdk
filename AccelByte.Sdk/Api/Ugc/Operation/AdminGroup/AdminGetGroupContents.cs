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
    /// AdminGetGroupContents
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [READ].
    /// </summary>
    public class AdminGetGroupContents : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetGroupContentsBuilder Builder = new AdminGetGroupContentsBuilder();

        public class AdminGetGroupContentsBuilder
            : OperationBuilder<AdminGetGroupContentsBuilder>
        {
            
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal AdminGetGroupContentsBuilder() { }


            public AdminGetGroupContentsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetGroupContentsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public AdminGetGroupContents Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                AdminGetGroupContents op = new AdminGetGroupContents(this,
                    groupId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetGroupContents(AdminGetGroupContentsBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetGroupContents(
            string groupId,            
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

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